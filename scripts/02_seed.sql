-- ============================================================
-- Hotel Reservation - Date inițiale (Seed)
-- Rulați după 01_schema.sql
-- ============================================================

USE hotel_reservation;

-- ── Camere ───────────────────────────────────────────────────
INSERT INTO camere (numar_camera, tip_camera, pret_noapte, etaj, activa) VALUES
  ('101', 'Single', 150.00, 1, 1),
  ('102', 'Single', 150.00, 1, 1),
  ('103', 'Double', 250.00, 1, 1),
  ('104', 'Double', 250.00, 1, 1),
  ('105', 'Suite',  450.00, 1, 1),
  ('201', 'Single', 170.00, 2, 1),
  ('202', 'Single', 170.00, 2, 1),
  ('203', 'Double', 280.00, 2, 1),
  ('204', 'Double', 280.00, 2, 1),
  ('205', 'Suite',  500.00, 2, 1),
  ('301', 'Single', 190.00, 3, 1),
  ('302', 'Double', 310.00, 3, 1),
  ('303', 'Suite',  600.00, 3, 1),
  ('304', 'Suite',  620.00, 3, 0)  -- inactivă
ON DUPLICATE KEY UPDATE pret_noapte = VALUES(pret_noapte);

-- ── Clienți ──────────────────────────────────────────────────
INSERT INTO clienti (nume, prenume, telefon, email, document_identitate) VALUES
  ('Popescu',  'Ion',      '0721000001', 'ion.popescu@email.ro',     'RO12345678'),
  ('Ionescu',  'Maria',    '0722000002', 'maria.ionescu@email.ro',   'RO23456789'),
  ('Georgescu','Alexandru','0723000003', 'alex.georgescu@email.ro',  'RO34567890'),
  ('Dumitrescu','Elena',   '0724000004', 'elena.d@email.ro',         'RO45678901'),
  ('Constantin','Mihai',   '0725000005', 'mihai.c@email.ro',         'RO56789012'),
  ('Munteanu', 'Ioana',    '0726000006', NULL,                        'RO67890123'),
  ('Popa',     'Andrei',   '0727000007', 'andrei.popa@email.ro',     'RO78901234'),
  ('Radu',     'Cristina', '0728000008', 'cristina.radu@email.ro',   'RO89012345')
ON DUPLICATE KEY UPDATE telefon = VALUES(telefon);

-- ── Rezervări ────────────────────────────────────────────────
INSERT INTO rezervari (client_id, camera_id, data_checkin, data_checkout, status_rezervare, pret_total)
SELECT
  (SELECT client_id FROM clienti WHERE document_identitate = 'RO12345678'),
  (SELECT camera_id FROM camere  WHERE numar_camera = '101'),
  CURDATE(), DATE_ADD(CURDATE(), INTERVAL 3 DAY),
  'Confirmata', 450.00
WHERE NOT EXISTS (
  SELECT 1 FROM rezervari r
  WHERE r.camera_id = (SELECT camera_id FROM camere WHERE numar_camera = '101')
    AND r.status_rezervare = 'Confirmata'
    AND r.data_checkin < DATE_ADD(CURDATE(), INTERVAL 3 DAY)
    AND r.data_checkout > CURDATE()
);

INSERT INTO rezervari (client_id, camera_id, data_checkin, data_checkout, status_rezervare, pret_total)
SELECT
  (SELECT client_id FROM clienti WHERE document_identitate = 'RO23456789'),
  (SELECT camera_id FROM camere  WHERE numar_camera = '103'),
  DATE_ADD(CURDATE(), INTERVAL 2 DAY), DATE_ADD(CURDATE(), INTERVAL 5 DAY),
  'Confirmata', 750.00
WHERE NOT EXISTS (
  SELECT 1 FROM rezervari r
  WHERE r.camera_id = (SELECT camera_id FROM camere WHERE numar_camera = '103')
    AND r.status_rezervare = 'Confirmata'
    AND r.data_checkin < DATE_ADD(CURDATE(), INTERVAL 5 DAY)
    AND r.data_checkout > DATE_ADD(CURDATE(), INTERVAL 2 DAY)
);

INSERT INTO rezervari (client_id, camera_id, data_checkin, data_checkout, status_rezervare, pret_total)
SELECT
  (SELECT client_id FROM clienti WHERE document_identitate = 'RO34567890'),
  (SELECT camera_id FROM camere  WHERE numar_camera = '205'),
  DATE_SUB(CURDATE(), INTERVAL 3 DAY), DATE_ADD(CURDATE(), INTERVAL 4 DAY),
  'Confirmata', 3500.00
WHERE NOT EXISTS (
  SELECT 1 FROM rezervari r
  WHERE r.camera_id = (SELECT camera_id FROM camere WHERE numar_camera = '205')
    AND r.status_rezervare = 'Confirmata'
    AND r.data_checkin < DATE_ADD(CURDATE(), INTERVAL 4 DAY)
    AND r.data_checkout > DATE_SUB(CURDATE(), INTERVAL 3 DAY)
);

INSERT INTO rezervari (client_id, camera_id, data_checkin, data_checkout, status_rezervare, pret_total)
SELECT
  (SELECT client_id FROM clienti WHERE document_identitate = 'RO45678901'),
  (SELECT camera_id FROM camere  WHERE numar_camera = '303'),
  DATE_SUB(CURDATE(), INTERVAL 10 DAY), DATE_SUB(CURDATE(), INTERVAL 7 DAY),
  'Finalizata', 1800.00;

INSERT INTO rezervari (client_id, camera_id, data_checkin, data_checkout, status_rezervare, pret_total)
SELECT
  (SELECT client_id FROM clienti WHERE document_identitate = 'RO56789012'),
  (SELECT camera_id FROM camere  WHERE numar_camera = '202'),
  DATE_ADD(CURDATE(), INTERVAL 10 DAY), DATE_ADD(CURDATE(), INTERVAL 12 DAY),
  'Confirmata', 340.00;

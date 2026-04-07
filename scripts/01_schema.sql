-- ============================================================
-- Hotel Reservation - Schema SQL
-- Compatibil MySQL 5.7+ / 8.0+
-- ============================================================

CREATE DATABASE IF NOT EXISTS hotel_reservation
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE hotel_reservation;

-- ── Tabel: camere ────────────────────────────────────────────
CREATE TABLE IF NOT EXISTS camere (
  camera_id      INT            AUTO_INCREMENT PRIMARY KEY,
  numar_camera   VARCHAR(10)    NOT NULL,
  tip_camera     ENUM('Single','Double','Suite') NOT NULL DEFAULT 'Single',
  pret_noapte    DECIMAL(10,2)  NOT NULL DEFAULT 0.00,
  etaj           INT            NOT NULL DEFAULT 1,
  activa         TINYINT(1)     NOT NULL DEFAULT 1,
  CONSTRAINT uq_numar_camera UNIQUE (numar_camera),
  CONSTRAINT chk_pret_noapte CHECK (pret_noapte >= 0),
  CONSTRAINT chk_etaj        CHECK (etaj >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ── Tabel: clienti ───────────────────────────────────────────
CREATE TABLE IF NOT EXISTS clienti (
  client_id          INT          AUTO_INCREMENT PRIMARY KEY,
  nume               VARCHAR(100) NOT NULL,
  prenume            VARCHAR(100) NOT NULL,
  telefon            VARCHAR(20)  NOT NULL,
  email              VARCHAR(120) NULL,
  document_identitate VARCHAR(30) NOT NULL,
  CONSTRAINT uq_document UNIQUE (document_identitate)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ── Tabel: rezervari ─────────────────────────────────────────
CREATE TABLE IF NOT EXISTS rezervari (
  rezervare_id    INT            AUTO_INCREMENT PRIMARY KEY,
  client_id       INT            NOT NULL,
  camera_id       INT            NOT NULL,
  data_checkin    DATE           NOT NULL,
  data_checkout   DATE           NOT NULL,
  status_rezervare ENUM('Confirmata','Anulata','Finalizata') NOT NULL DEFAULT 'Confirmata',
  pret_total      DECIMAL(10,2)  NOT NULL DEFAULT 0.00,
  CONSTRAINT fk_rez_client FOREIGN KEY (client_id)
    REFERENCES clienti(client_id) ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT fk_rez_camera FOREIGN KEY (camera_id)
    REFERENCES camere(camera_id)  ON UPDATE CASCADE ON DELETE RESTRICT,
  CONSTRAINT chk_perioada  CHECK (data_checkout > data_checkin),
  CONSTRAINT chk_pret_total CHECK (pret_total >= 0)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

-- ── Indecși pentru performanță ────────────────────────────────
CREATE INDEX IF NOT EXISTS idx_rez_camera_checkin  ON rezervari(camera_id, data_checkin);
CREATE INDEX IF NOT EXISTS idx_rez_status          ON rezervari(status_rezervare);
CREATE INDEX IF NOT EXISTS idx_rez_period          ON rezervari(data_checkin, data_checkout);

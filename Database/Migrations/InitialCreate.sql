-- Table: Users
CREATE TABLE users (
                       id SERIAL PRIMARY KEY,
                       name VARCHAR(100) NOT NULL,
                       email VARCHAR(100) UNIQUE NOT NULL,
                       password_hash TEXT NOT NULL,
                       role VARCHAR(20) NOT NULL, -- admin, approver, etc.
                       created_at TIMESTAMP DEFAULT NOW()
);

-- Table: Vehicles
CREATE TABLE vehicles (
                          id SERIAL PRIMARY KEY,
                          plate_number VARCHAR(20) UNIQUE NOT NULL,
                          type VARCHAR(50) NOT NULL, -- person_transport / goods_transport
                          is_rented BOOLEAN DEFAULT FALSE,
                          status VARCHAR(20) DEFAULT 'available',
                          created_at TIMESTAMP DEFAULT NOW()
);

-- Table: Drivers
CREATE TABLE drivers (
                         id SERIAL PRIMARY KEY,
                         name VARCHAR(100) NOT NULL,
                         phone_number VARCHAR(20),
                         license_number VARCHAR(50)
);

-- Table: BookingRequests
CREATE TABLE booking_requests (
                                  id SERIAL PRIMARY KEY,
                                  requester_id INTEGER REFERENCES users(id),
                                  vehicle_id INTEGER REFERENCES vehicles(id),
                                  driver_id INTEGER REFERENCES drivers(id),
                                  start_date TIMESTAMP NOT NULL,
                                  end_date TIMESTAMP NOT NULL,
                                  purpose TEXT,
                                  status VARCHAR(20) DEFAULT 'pending', -- pending, approved, rejected
                                  created_at TIMESTAMP DEFAULT NOW()
);

-- Table: Approvals (multilevel approval: level 1, 2)
CREATE TABLE approvals (
                           id SERIAL PRIMARY KEY,
                           booking_request_id INTEGER REFERENCES booking_requests(id) ON DELETE CASCADE,
                           approver_id INTEGER REFERENCES users(id),
                           approval_level INTEGER NOT NULL,
                           approved BOOLEAN,
                           approved_at TIMESTAMP
);

-- Table: ServiceRecords
CREATE TABLE service_records (
                                 id SERIAL PRIMARY KEY,
                                 vehicle_id INTEGER REFERENCES vehicles(id),
                                 service_date TIMESTAMP NOT NULL,
                                 description TEXT,
                                 mileage INTEGER
);

-- Table: FuelConsumptions
CREATE TABLE fuel_consumptions (
                                   id SERIAL PRIMARY KEY,
                                   vehicle_id INTEGER REFERENCES vehicles(id),
                                   fill_date TIMESTAMP NOT NULL,
                                   fuel_volume DECIMAL(10,2), -- liters
                                   cost DECIMAL(12,2)
);

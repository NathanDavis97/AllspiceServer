use allspice2;

CREATE TABLE recipes (
  id INT NOT NULL AUTO_INCREMENT,
  title VARCHAR(255) NOT NULL,
  description VARCHAR(255),
  imgUrl VARCHAR(255),
  PRIMARY KEY (id)
);

-- CREATE TABLE ingredients (
--   id INT NOT NULL AUTO_INCREMENT,
--   title VARCHAR(255) NOT NULL,
--   quantity INT NOT NULL,
--   recipeId INT NOT NULL,

--   PRIMARY KEY (id),

--   FOREIGN KEY (recipeId)
--     REFERENCES recipes (id)
--     ON DELETE CASCADE
-- );




-- DANGER ZONE

-- ALTER A TABLE
-- ALTER TABLE reviews
--   ADD COLUMN date DATE



-- DELETE ALL DATA WITHIN A COLLECTION
-- DELETE FROM reviews;

-- DELETE ENTIRE COLLECTION TABLE
-- DROP TABLE reviews;

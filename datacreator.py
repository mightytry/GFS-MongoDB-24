import json
import random
from faker import Faker

fake = Faker("de_DE")

class Address():
    def __init__(self):
        self.strasse = fake.street_name()
        self.hausnummer = fake.building_number()
        self.plz = int(fake.postcode().split("-")[0])
        self.ort = fake.city()

class User():
    def __init__(self):
        gender = random.choice(['m', 'w'])
        self.vorname = fake.first_name_female() if (gender == "w") else fake.first_name_male()
        self.name = fake.last_name()
        self.geschlecht = gender
        self.alter = random.randint(10, 80)
        self.freunde = [fake.first_name() for i in range(random.randint(0, 5))]
        self.email = f"{self.vorname}.{self.name}@{fake.free_email_domain()}".lower()
        self.adresse = Address()
        self.jahre_seit_registrierung = random.randint(0, 11)
        if random.randint(0, 1) == 1:
            self.telefon = fake.phone_number()


def main():
    users = [User() for i in range(10000)]
    open("data.json", "w").write(json.dumps(users, default=lambda x: x.__dict__, indent=4, ensure_ascii=False))

if __name__ == "__main__":
    main()
class BaseClass:
    contacts = []  # lista de todos los contactos

    # guarda a cada contacto en la lista
    def add_contact(self, name, email, phone):
        user_data = {"name": name, "email": email, "phone": phone}
        self.contacts.append(user_data)

    def update_contact(self, email, name, phone):
        contact = self.search_contact(email)
        if contact is not None:
            contact["name"] = name
            contact["phone"] = phone
            return True
        return False

    @classmethod
    def search_contact(cls, email):
        for contact in cls.contacts:
            if contact["email"] == email:
                return contact
        return None

    @classmethod
    def all_contacts(cls):
        return cls.contacts


class Contacts(BaseClass):
    def add(self, name, email, phone):
        self.add_contact(name, email, phone)

    # imprime todos los contactos
    def show_all_contacts(self):
        contacts = self.all_contacts()
        for contact in contacts:
            print(f"{contact['name']} - {contact['email']} - {contact['phone']}")

    def search(self, email):
        return self.search_contact(email)

    def update(self, email, name, phone):
        return self.update_contact(email, name, phone)
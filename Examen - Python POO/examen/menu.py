class MainMenu:
    # para el uso del menu principal
    @staticmethod
    def showMainMenu():
        print("*****************************************************")
        print("ALFREDO - PYTHON CONTACTS")
        print("*****************************************************")
        print("1. Añadir contacto")
        print("2. Listar contactos")
        print("3. Buscar contacto")
        print("4. Editar contacto")
        print("5. Cerrar aplicación")
        option = int(input("Seleccione una opción: "))
        while option > 5 or option < 1:
            print("Opción no válida.")
            option = int(input("Seleccione una opción: "))
        else:
            return option

    @staticmethod
    def showMenuAddContact():
        print("*****************************************************")
        print("AÑADIR CONTACTO")
        print("*****************************************************")

    @staticmethod
    def addContact():
        name = input("Ingrese el nombre: ")
        email = input("Ingrese el correo: ")
        phone = input("Ingrese el teléfono: ")
        return name, email, phone

    @staticmethod
    def showMenuAllContacts():
        print("*****************************************************")
        print("              LISTA DE CONTACTOS             ")
        print("*****************************************************")
        print("Nombre     |    correro    | Teléfono")

    @staticmethod
    def showMenuSearchContact():
        print("*****************************************************")
        print("              BUSCAR CONTACTO                 ")
        print("*****************************************************")

    @staticmethod
    def searchContact():
        email = input("Ingrese correo de contacto: ")
        return email

    @staticmethod
    def showMenuUpdate():
        print("*****************************************************")
        print("              EDITAR CONTACTO                 ")
        print("*****************************************************")

    @staticmethod
    def getContactEmail():
        return input("Ingrese correo de contacto: ")

    def getContactData():
        name = input("Ingrese nombre de contacto: ")
        phone = input("Ingrese teléfono de contacto: ")
        return name, phone
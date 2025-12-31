# Clase
class Usuario():
    # Atributos
    def __init__(self, nombre, apellido, correo, contrasenia, telefono):
        self.nombre = nombre
        self.apellido = apellido
        self.correo = correo
        self.contrasenia = contrasenia
        self.telefono = telefono

    # Metodos
    def encriptarContrasenia(self):
        return "encriptado"

    def verificarContrasenia(self):
        return "desencriptado"

# Objeto
usuario1 = Usuario()

# Definir atributos manualmente
usuario1.nombre = "Alfredo"
usuario1.apellido = "Navarro"
usuario1.correo = "alfredont1088@gmail.com"
usuario1.contrasenia = "123456"
usuario1.telefono = "931642634"

# Definir atributos mediante el constructor
usuario2 = Usuario("Aldy", "Montoya", "aldy.montoya@tecsup.edu.pe", "123456", "912345761")

from cryptocode import encrypt, decrypt

class Usuario:
    def __init__(self, nombre, apellido, correo, contrasenia, telefono):
        self._nombre = nombre
        self._apellido = apellido
        self._correo = correo
        self._contrasenia = self.encriptarContrasenia(contrasenia)
        self._telefono = telefono

    def encriptarContrasenia(self, contrasenia):
        return encrypt(contrasenia, "secret")
    
    def verificarContrasenia(self, contrasenia):
        contrasenia_desencriptada = decrypt(self.contrasenia, "secret")
        return contrasenia_desencriptada == contrasenia

    # Getter (devuelve el valor de un atributo)
    @property
    def nombre(self):
        return self._nombre
    
    # Setter (define el valor de un atributo)
    @nombre.setter
    def nombre(self, nombre):
        self._nombre = nombre

    # Getter (devuelve el valor de un atributo)
    @property
    def apellido(self):
        return self._apellido
    
    # Setter (define el valor de un atributo)
    @apellido.setter
    def apellido(self, apellido):
        self._apellido = apellido

usuario1 = Usuario("Alfredo", "Navarro", "alfredo.navarro@gmail.com", "1234", "943391168")

print(usuario1.nombre)
print(usuario1.apellido)

usuario1.nombre = "Aldy"
usuario1.apellido = "Montoya"

print(usuario1.nombre)
print(usuario1.apellido)
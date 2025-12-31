class Usuario:
    def __init__(self, nombre, apellido, correo, contrasenia):
        # Atributos públicos
        self.nombre = nombre
        self.apellido = apellido
        # Atributos privados
        self.__correo = correo
        self.__contrasenia = self.encriptarContrasenia(contrasenia)

    def obtener_correo(self):
        return self.__correo
        
    def actualizar_telefono(self, nuevo_correo):
        self.__correo = nuevo_correo

    def encriptarContrasenia(self, contrasenia):
        pass

    def verificarContrasenia(self, contrasenia):
        pass

usuario1 = Usuario("Alfredo", "Navarro", "anavarro@gmail.com", "1234")

print(usuario1.obtener_correo())
# Primera clase padre
class Mascota:
    # Constructor
    def __init__(self, nombre):
        self.nombre = nombre

    def juega(self):
        print(f"La mascota {self.nombre} esta jugando")

# Segunda clase padre y primera clase hijo
class Perro(Mascota):
    # Constructor
    def __init__(self, nombre, raza):
        # Constructor de la super clase Mascota
        super().__init__(nombre)
        self.raza = raza

    def juega(self):
        # Se invoca el metodo juega de la super clase Mascota
        super().juega()
        print(f"El perro de raza {self.raza} juega con su hueso")

class PerroDomestico(Perro):
    def __init__(self, nombre, raza, propietario):
        # Se invoca el metodo juega de la super clase Perro
        # Se vuelve una función anidada, va a llamar juega(Perro) y luego juega(Mascota)
        super().__init__(nombre, raza)
        self.propietario = propietario

    def juega(self):
        super().juega()
        print(f"El perro domestico mueve la cola")

    def presentarse(self):
        print(f"Hola, soy {self.nombre}, de raza {self.raza} y mi dueño es {self.propietario}")



pd = PerroDomestico("Max", "Chihuahua", "Alfredo")
pd.juega()
pd.presentarse()
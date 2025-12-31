# Clase padre
class Vehiculo:
    # Atributos
    def __init__(self, marca, modelo, velociodad, anio):
        self.marca = marca
        self.modelo = modelo
        self.velocidad = velociodad
        self.anio = anio

    # Métodos
    def darVelocidad(self, velocidad):
        self.velocidad += velocidad

    def reducirVelocidad(self, velocidad):
        self.velocidad -= velocidad

# Clase hijo
class Motocicleta(Vehiculo):
    # Atributos
    def __init__(self, marca, modelo, velociodad, anio, motor):
        self.motor = motor
        super().__init__(marca, modelo, velociodad, anio)

    # Métodos
    def Wheelie(self):
        return "Haciendo el wheelie..."

# Clase hijo
class Autobus(Vehiculo):
    # Atributos
    def __init__(self, marca, modelo, velociodad, anio, motor, asientos):
        self.motor = motor
        self.asientos = asientos
        super().__init__(marca, modelo, velociodad, anio)

    # Métodos
    def cargarPasajeros(self, pasajeros):
        return f"pasajero a bordo {pasajeros}"
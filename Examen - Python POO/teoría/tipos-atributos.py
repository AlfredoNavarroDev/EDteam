# Atributos de clase: Son compartidos de forma general para todas las instancias de la clase.
# Atributos de instancia: Son diferentes para cada una de las instancias que le asigna valores.
# Atributos de datos: Son únicos para la instancia en la que se crea y se inicializa.

class Vehiculo:
    # Atributos de la clase
    ruedas = 4

    # Atributos de instancia
    def __init__(self,marca, modelo, velocidad):
        self.marca = marca
        self.modelo = modelo
        self.velocidad = velocidad

    # Métodos
    def darVelocidad(self, velocidad):
        self.velocidad += velocidad

    def reducirVelocidad(self, velocidad):
        self.velocidad -= velocidad

# Atributos de instancias
vehiculo1 = Vehiculo("Ford", 2022, 20)
print(vehiculo1.marca)
print(vehiculo1.modelo)
print(vehiculo1.velocidad)

print()

# Atributos de clase
print(vehiculo1.ruedas)
Vehiculo.ruedas = 6
print(vehiculo1.ruedas)

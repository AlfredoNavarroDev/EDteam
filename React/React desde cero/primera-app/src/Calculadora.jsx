// UseState nos permite usar el estado de los componentes funcionales
import { useState, useEffect, useRef } from "react"

const Calculadora = ( { nombre } ) => {

    const [texto, setTexto] = useState("")

    const [numeros, setNumeros] = useState({
        numero1: 0,
        numero2: 0
    })

    // useEffect: Se ejecuta cuando se construye el componente
    // El segundo parametro es un arreglo opcional de dependencias
    // El arreglo será el listado de todos los estados que quiero controlar como
    // disparadores de la actualización de mi componente

    // Si no le paso array como 2do parametro. El useEffect vuevle a correr siempre
    // que algún estado se actualice
    useEffect( () => {
        console.log(new Date().toLocaleString());
        return() => {
            // Aquí va lo que quieras ejecutar cuando el componente se desmonte
        }
    }, [] )

    useRef();

    const setNumber1 = (e) => {
        setNumeros({
            ...numeros,
            numero1: parseFloat(e.target.value)
        })
    }

    const setNumber2 = (e) => {
        setNumeros({
            ...numeros,
            numero2: parseFloat(e.target.value)
        })
    }


    // Segundo paso del ciclo de vida
        return (
            <>
                <h2>{nombre}</h2>
                <form>
                    <input
                    type="number"
                    name="numero1"
                    value={numeros.numero1}
                    onChange={setNumber1}
                    />

                    <input
                    type="number"
                    name="numero2"
                    value={numeros.numero2}
                    onChange={setNumber2}
                    />

                    <input type="submit" name="Calcular" value="Calcular"/>
                </form>
                <span>Resultado: { numeros.numero1 + numeros.numero2 }</span>
                <input type="text" onChange={(e) => {setTexto(e.target.value) }}/>
                <span>{ texto }</span>
            </>
        )
}

export default Calculadora;
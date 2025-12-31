// UseRef nos permite crear una referencia hacia un elemento del DOM

import { useRef } from 'react';
import './Curso.css';
const Curso = ({ imagen, titulo, subtitulo }) => {
    const miReferenciaImagen = useRef();
    const miReferenciaTexto = useRef();

    var oculto = false;

    const desactivarImagen = () => {
        oculto = !oculto;
        if(oculto == false) {
            miReferenciaImagen.current.classList.remove("desactivada");
            miReferenciaTexto.current.innerText = "Desactivar";
        }else {
            miReferenciaImagen.current.classList.add("desactivada")
            miReferenciaTexto.current.innerText = "Activar";
        };
    }

    return(
        <div>
            <img ref={miReferenciaImagen} src={imagen} alt={titulo} />
            <h2>{titulo}</h2>
            <p>{subtitulo}</p>
            <button ref={miReferenciaTexto} onClick={desactivarImagen} >Desactivar</button>
        </div>
    )
}

export default Curso;
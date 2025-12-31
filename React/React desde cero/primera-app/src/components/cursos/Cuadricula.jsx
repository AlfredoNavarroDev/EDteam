import Curso from './Curso';
const Cuadricula = () => {
    return(
        <div className="main-content">
            <Curso
            imagen= "https://edteam-media.s3.amazonaws.com/courses/medium/3aa59acc-3472-4875-b9c6-216825be755b.png"
            titulo="Curso: MySQL"
            subtitulo= "Aprende a crear y administrar bases de datos con el motor de código abierto más popular de la web."
            />

            <Curso
            imagen= "https://edteam-media.s3.amazonaws.com/courses/medium/ef0d92b3-74d6-4bec-bc4f-baa18dcf558e.png"
            titulo="Curso: Express desde cero"
            subtitulo= "Aprende a configurar tu servidor web con el framework más popular de Node.js"
            />

            <Curso
            imagen= "https://edteam-media.s3.amazonaws.com/courses/medium/f6bce450-f6c2-4c83-8d1a-ff48c1cb8b1a.png"
            titulo="Curso: Node.js desde cero"
            subtitulo= "Aprende a crear aplicaciones con JavaScript en el lado del servidor usando la última versión de Node.js."
            />

            <Curso
            imagen= "https://edteam-media.s3.amazonaws.com/courses/medium/1fc49db5-2454-43e5-b94b-bed0d98719f2.png"
            titulo="Curso: JavaScript desde cero"
            subtitulo= "Domina las bases del único lenguaje que te da la oportunidad de trabajar del lado del cliente y del lado del servidor."
            />
        </div>
    )
}

export default Cuadricula;
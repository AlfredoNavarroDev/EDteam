import Calculadora from '../Calculadora';
import Header from './header/Header';
import Cuadricula from './cursos/Cuadricula';

const App = () => {
  return (
    <>
      <Header />
      <main>
        <h1>Simple Calculadora</h1>
        <Cuadricula />
      </main>
    </>
  )
}

export default App;
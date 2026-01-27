import 'reflect-metadata';
/*

--- TYPE ---

type NumeroPares = 2 | 4 | 6 | 8;
const aceptaParesDel1Al10 = (n: NumeroPares) => {
    console.log("El número es valido");
}

aceptaParesDel1Al10(3);
aceptaParesDel1Al10(2);
*/

// -----------------------------------------------------------

/*

--- ENUM ---

enum PAISES {
    BOL = 'BOL',
    COL = 'COL',
    ARG = 'ARG'
}

type TPAISES = PAISES;

const verificaSiEsBCA = (pais: TPAISES) => {
    if (pais === PAISES.BOL) {
        console.log("Es Boliviano");
    }else if (pais === PAISES.COL) {
        console.log("Es Colombiano");
    }else if (pais === PAISES.ARG) {
        console.log("Es Argentino");
    } else {
        console.log("Es cualquier webada");
    }
}

verificaSiEsBCA(PAISES.COL);
verificaSiEsBCA("PER");
*/

// -----------------------------------------------------------

/*

--- TUPLES ---

type indiceNumero = number;
type numeroTexto = string;

const numeroUno: [indiceNumero, numeroTexto] = [1, "UNO"];
const numeroDos: [indiceNumero, numeroTexto] = [2, "DOS"];
const numeroTres: [indiceNumero, numeroTexto] = [3, "TRES"];
const numeroCuatro: [indiceNumero, numeroTexto] = [4, "CUATRO"];
*/

// -----------------------------------------------------------

/*

--- NEVER ---

const BACKEND_API:string = "https://api.edteam.com";

let PING: unknown = 80;

PING = null;

// PING = 240;

function validarPing(): never {
    throw new Error('No hay conexión');
}

validarPing();
*/

// -----------------------------------------------------------

/*

--- VOID ---

let PING: unknown = 80;

PING = null;

// PING = 240;

function validarPing(): void {
    if (typeof PING !== 'undefined') {
        console.log("OK");
    }
    throw new Error('No hay conexión');
}

validarPing();
*/

// -----------------------------------------------------------

/*
-- ARGUMENTOS REST --

type AUTENTICADO = {
    jwt: string;
    userId: string;
    role: string;
    level: number;
}

// level es opcional

const isAuth = (jwt: string, userId: string = "admin123", role: string = "customer", level?: number): AUTENTICADO => {
    return {
        userId,
        jwt,
        role,
        level: level ?? 10
    };
}

type ARGS = string | number | boolean;
// o "any" en vez de ARGS
const argumentos = (...args: ARGS[]) => {
    return args;
}

const respuesta = isAuth("bmndfada", "12bc3");
console.log(respuesta);

const respuestaDos = isAuth("bmnaszfada", "12bxy145", "user",13);
console.log(respuestaDos);

const respuestaTres = isAuth("bmnaszfadf");
console.log(respuestaTres);

const resultado4 = argumentos(1, 3.14, true, "hola");
console.log(resultado4);

*/

// -----------------------------------------------------------

/*
-- OVERLOADING --

type Args = number | string;

function transformarNumero(num: number): number;
function transformarNumero(num: string): string;

function transformarNumero (num: Args ): Args {
    // Toda la logica
    return num;
}

const resultado = transformarNumero(52);
console.log(resultado);
*/

// -----------------------------------------------------------

/*

-- INTERFACES --

type direccion = string | undefined;

type ciudad = direccion & {
    lugar:string;
};

interface base {
    id: string;
    direccion?: direccion;
}

interface Materia {
    nombre: string;
    anio: number;
}

interface Usuario extends base {
    nombre: string;
    email: string;
    edad: number;
    mat: Materia;
}

interface Persona extends base {
    phone: number;
}

const usuario: Usuario = {
    id: "ab12",
    nombre: "Juan",
    email: "juan@edteam.com",
    edad: 30,
    mat: {
        nombre: "TypeScript",
        anio: 2026
    }
};

const persona: Persona = {
    id: "cd13",
    direccion: "Urb. Palmeras",
    phone: 943391168
}

console.log(usuario);
console.log(persona);
*/

// -----------------------------------------------------------

/*

-- POO --

class Usuario {
    private name: string;
    private email: string;
    private age: number;
    
    constructor(name: string, email: string, age: number) {
        this.name = name;
        this.email = email;
        this.age = age;
    }

    getName(): string {
        return this.name;
    }

    setName(anotherName: string): void {
        this.name = anotherName;
    }
}

const user = new Usuario("Juan", "juan@edteam.com", 30);
console.log(user);
user.setName("Pedro");
console.log(user.getName());

*/

// -----------------------------------------------------------

/*

-- UNION TYPES & GUARDS --
class ErrorResponse {
    code: number = 404;
}

class SuccessResponse {
    code: number = 200;
    response: string = '';
}

interface Res {
    data: any;
    code: any;
}

type Request = ErrorResponse | SuccessResponse;

async function get(req: Request): Promise<Res | undefined> {
    let res: Res = {
        data: null,
        code: 500
    }
    try{
        const data = await fetch('https://api.example.com/data');
        
        if (data) {
            if (req instanceof SuccessResponse) {
                res = { data, code: req.code };
            }
        } else {
            if (req instanceof ErrorResponse) {
                res = { data: data, code: req.code };
            }
        }
        
    } catch (error) {
        console.log(error);
    } finally {
        return res;
    }
}
*/

// -----------------------------------------------------------

/*

-- UNION TYPES & INTERSECTIONS --


type alfanumerico = string | number;
type numerico = number | undefined;

type KEY = alfanumerico | numerico;

const n: KEY = 2;
const n2: KEY = "2";
const n3: KEY = undefined;

*/

// -----------------------------------------------------------

/*

-- CASTING --

const canvas = document.getElementById('#canvas');
const context2D = (canvas as HTMLCanvasElement).getContext('2d');
*/

// -----------------------------------------------------------

/*

-- OPTIONAL CHAINING --

const button = document.getElementById("#btn");

button?.addEventListener('click', () => {
    alert('Hola Mundo :D')
});

const user = {
    name: undefined,
    email: ''
};

// valida que name no sea undefined
if(user?.name){
    // bloque de codig
}
*/

// -----------------------------------------------------------

/*

-- DECORATORS --

function Decorator(target: any) {
    target.prototype.dni = new Map();
    target.prototype.email = "adria@gmail.com";
    target.prototype.generatedKey = function () 
    {
        return target.prototype.email = 'otro valor';
    };
}

interface User {
    name: string;
    age: number;
    email: string;
}

@Decorator
class User {
    name: string;
    age: number;

    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }
}

@Decorator
class User2 {
    name: string;
    age: number;

    constructor(name: string, age: number) {
        this.name = name;
        this.age = age;
    }
}

const user = new User("Juan", 30);
console.log(user);
*/

// -----------------------------------------------------------

interface User {
    name: string;
    age: number;
}

const user: User = {
    name: "Juan",
    age: 30
};

interface Ping<T, U> {
    host: T;
    user: U;
}

const Network: Ping<boolean, User> = {
    host: true,
    user: user
};
console.log(Network);
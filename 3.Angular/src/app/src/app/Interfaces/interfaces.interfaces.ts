import { Time } from "@angular/common";

//Definir claves foráneas una vez generada la API
export interface Cuenta {
    cvu: number;
    alias: string;
    saldo: number;
    usuarioDni: number;
    tipoMoneda: TipoMoneda;
}

export interface Deposito {
    id: number;
    fecha: Date;
    hora: Time;
    tipoDeposito: TipoDeposito;
    tarjeta: Tarjeta;
    cvu: Cuenta;
    codigoSeguridad: number;
}

export interface Destino {
    aliasCvu: string;
    propietario: string;
    correo: string;
    dni: number;
}

export interface Empresa {
    id: number;
    nombre: string;
}

export interface Tarjeta {
    numero: number;
    fechaVencimiento: Date;
    codigoDeSeguridad: number;
    propietario: string;
    dni: number;
    empresa: number;
}

export interface TipoDeposito{
    id: number;
    nombre: string;
}

export interface TipoMoneda{
    id: number;
    nombre: string;
}

export interface Transferencia{
    id: number;
    fecha: Date;
    hora: Time;
    nota: string;
    cvu: Cuenta;
    destino: Destino;
}



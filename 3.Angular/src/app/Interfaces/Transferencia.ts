export interface Transferencia {
    idTransferencia: number;
    fecha:           Date;
    hora:            Hora;
    cuenta:          Cuenta;
    nota:            string;
    monto:           number;
    destino:         Destino;
}

export interface Cuenta {
    cvu:        number;
    alias:      string;
    saldo:      number;
    usuario:    Usuario;
    tipoMoneda: TipoMoneda;
}

export interface TipoMoneda {
    idTipoMoneda: number;
    nombre:       string;
}

export interface Usuario {
    apellido: string;
    nombre:   string;
    correo:   string;
    dni:      number;
    password: string;
}

export interface Destino {
    cvuAlias:    string;
    propietario: string;
    correo:      string;
    dni:         number;
}

export interface Hora {
}

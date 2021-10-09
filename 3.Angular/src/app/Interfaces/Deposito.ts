export interface Deposito {
    idDeposito: number;
    fecha:      Date;
    hora:       Hora;
    cuenta:     Cuenta;
    monto:      number;
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

export interface Hora {
}

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

import { TipoMoneda } from "./TipoMoneda";

export interface Cuenta {
    cvu:          number;
    alias:        string;
    saldo:        number;
    dni:          number;
    idTipoMoneda: TipoMoneda;
}


export class LinijaDetalji {
    NazivLinije : string;
    Stanice: string[];
    VremenaDolaska: string[];

    

    constructor(_stanice : string[], _vremena : string[], _naziv : string)
    {
      this.NazivLinije = _naziv;
      this.Stanice = _stanice;
      this.VremenaDolaska = _vremena;
    }
  }
  
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatTableDataSource } from '@angular/material/table';
import { Trabajador } from 'src/app/interface/trabajador';
import { Trabajadorequest } from 'src/app/interface/trabajadorequest';
import { TrabajadorService } from 'src/app/services/trabajador.service';

@Component({
  selector: 'app-trabajador',
  templateUrl: './trabajador.component.html',
  styleUrls: ['./trabajador.component.css']
})
export class TrabajadorComponent implements OnInit {

  Myformulario: FormGroup
  dataSource = new MatTableDataSource<Trabajador>();

  displayedColumns: string[] = ['DNI','SALARIO','TIPO'];

  constructor(private fb:FormBuilder,private _TrabajadorService: TrabajadorService) {
    this.Myformulario = this.fb.group({
      dni:['',Validators.required],
      horasLaboradas:['',Validators.required],
      diasLaboradas:['',Validators.required],
      faltas:['',Validators.required],
      tipoTrabajador:['',Validators.required],
    })
   }

   //ListTrabajador! : Trabajador[]

  ngOnInit(): void {
  }

  GuardarMascota(){
    const trabajador : Trabajadorequest={
      dni : this.Myformulario.value.dni,
      horasLaboradas : this.Myformulario.value.horasLaboradas,
      diasLaborados : this.Myformulario.value.diasLaboradas,
      faltas : this.Myformulario.value.faltas,
      TipoTrabajador:this.Myformulario.value.tipoTrabajador
    }

    //Paso la data a la tabla
    this._TrabajadorService.ResumenTrabajador(trabajador).subscribe(data=>{
      this.dataSource.data = data;
    },error =>{
      alert("error :/");
    });
  }
}

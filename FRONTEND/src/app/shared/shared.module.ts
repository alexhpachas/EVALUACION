import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

//MODULO FORMULARIO REACTIVO
import { ReactiveFormsModule } from '@angular/forms';
//para vincular el backend con fronend
import { HttpClientModule } from '@angular/common/http';

//ANGULAR MATERIAL

import { MatSliderModule } from '@angular/material/slider';
import {MatTableModule} from '@angular/material/table';
import {MatPaginatorModule} from '@angular/material/paginator';
import {MatSortModule} from '@angular/material/sort';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatIconModule} from '@angular/material/icon';
import {MatTooltipModule} from '@angular/material/tooltip';
import {MatProgressBarModule} from '@angular/material/progress-bar';
import {MatButtonModule} from '@angular/material/button';
import {MatCardModule} from '@angular/material/card';
import {MatSnackBarModule} from '@angular/material/snack-bar';
import { SpinnerComponent } from './spinner/spinner.component';
import {MatGridListModule} from '@angular/material/grid-list';



@NgModule({
  declarations: [
    SpinnerComponent
  ],
  imports: [
    CommonModule,
    MatSliderModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    MatTooltipModule,
    MatProgressBarModule,
    MatButtonModule,
    MatCardModule,
    MatSnackBarModule,
    MatGridListModule,
    ReactiveFormsModule,
    HttpClientModule
  ],
  exports:[
    CommonModule,
    MatSliderModule,
    MatTableModule,
    MatPaginatorModule,
    MatSortModule,
    MatFormFieldModule,
    MatInputModule,
    MatIconModule,
    MatTooltipModule,
    MatProgressBarModule,
    MatButtonModule,
    MatCardModule,
    MatSnackBarModule,
    SpinnerComponent,
    MatGridListModule,
    ReactiveFormsModule,
    HttpClientModule
  ]
})
export class SharedModule { }

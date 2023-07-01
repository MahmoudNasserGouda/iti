import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeListComponent } from './Components/employee-list/employee-list.component';
import {MatTableModule} from '@angular/material/table';
import { AddEmployeeComponent } from './Components/add-employee/add-employee.component';
import { FormsModule } from '@angular/forms';
import {MatButtonModule} from '@angular/material/button';
import {MatIconModule} from '@angular/material/icon';
import {MatDividerModule} from '@angular/material/divider';
import { EditEmployeeComponent } from './Components/edit-employee/edit-employee.component';
import { ReactiveFormsModule } from '@angular/forms';
const routes:Routes =[
  {path: 'employee-list', component: EmployeeListComponent},
  {path: 'add', component: AddEmployeeComponent},
  {path: 'edit/:id', component: EditEmployeeComponent},
];

@NgModule({
  declarations: [
    EmployeeListComponent,
    AddEmployeeComponent,
    EditEmployeeComponent
  ],
  imports: [
    CommonModule,
    MatTableModule,
    FormsModule,
    MatButtonModule,
    MatDividerModule, MatIconModule,
    ReactiveFormsModule,
    RouterModule.forChild(routes)
  ]
})
export class EmployeeModule { }

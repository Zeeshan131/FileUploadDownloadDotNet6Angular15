import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { FileUploadComponent } from './file-upload/file-upload.component';
import { ViewFilesComponent } from './view-files/view-files.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'add', component: FileUploadComponent },
  { path: 'files', component: ViewFilesComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

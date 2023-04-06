import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-view-files',
  templateUrl: './view-files.component.html',
  styleUrls: ['./view-files.component.scss']
})
export class ViewFilesComponent {
  pageTitle = 'Welcome to View Files component';
  files: any = [];

  constructor(private http: HttpClient) {
    this.getAllFiles();
  }

  getAllFiles() {
    // debugger
    return this.http.get('https://localhost:7271/api/FileManager')
      .subscribe((result) => {
        this.files = result;
        // console.log(result);
      });
  }

  downloadFile(id: number, contentType: string) {
    return this.http.get(`https://localhost:7271/api/FileManager/${id}`, { responseType: 'blob' })
      .subscribe((result: Blob) => {
        const blob = new Blob([result], { type: contentType }); // you can change the type
        // console.log(blob);
        const url = window.URL.createObjectURL(blob);
        window.open(url);
        console.log("Success");
      });
  }
}

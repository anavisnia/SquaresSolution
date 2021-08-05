import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpRequest} from '@angular/common/http';
import { Observable} from 'rxjs';
import { Point } from '../Point';

const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type': 'application/json',
  })
};

@Injectable({
  providedIn: 'root'
})
export class PointService {

  apiUrl:string = 'https://localhost:44302/Points';
  fileUrl:string = 'https://localhost:44302/TextFile';

  constructor(private http:HttpClient) { }

  getPoints(): Observable<Point[]> {
    return this.http.get<Point[]>(this.apiUrl);
  }

  uploadFile(file) {
    if (file.length === 0)
      return;
  
    const formData = new FormData();
  
    formData.append('file', file);
  
    const uploadReq = new HttpRequest('POST', this.fileUrl, formData, {
      reportProgress: true,
    });
  
    this.http.request(uploadReq).subscribe(event => {
     
    });
  }

  // addPoint(point: Point): Observable<Point> {
  //   return this.http.post<Point>(this.apiUrl, point, httpOptions);
  // }

  // deletepoint(point: Point): Observable<Point> {
  //   const url = `${this.apiUrl}/${point.id}`;
  //   return this.http.delete<Point>(url, httpOptions);
  // }

  // updatePoint(point: Point): Observable<Point> {
  //   return this.http.post<Point>(this.apiUrl, point, httpOptions);
  // }

}

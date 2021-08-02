import { Component, OnInit,  Input } from '@angular/core';
import { Point } from 'src/app/Point';
import { PointService } from 'src/app/services/point.service';

@Component({
  selector: 'app-pointersview',
  templateUrl: './pointersview.component.html',
  styleUrls: ['./pointersview.component.css']
})
export class PointersviewComponent implements OnInit {
  points: Point[] = [];
  constructor(private pointService: PointService) { }

  ngOnInit(): void {
    this.pointService.getPoints().subscribe((points) => this.points = points);
  }

}

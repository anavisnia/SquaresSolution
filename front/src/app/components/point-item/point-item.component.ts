import { Component, OnInit, Input } from '@angular/core';
import { Point } from 'src/app/Point';
import { Subscription } from 'rxjs';
import { PointService } from 'src/app/services/point.service';

@Component({
  selector: 'app-point-item',
  templateUrl: './point-item.component.html',
  styleUrls: ['./point-item.component.css']
})
export class PointItemComponent implements OnInit {
  @Input() point!: Point;
  subscription?: Subscription;
  constructor(private pointService: PointService) { }

  ngOnInit(): void {
  }

}

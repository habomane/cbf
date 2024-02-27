import { Component } from '@angular/core';
import { AdhanService } from 'src/app/services/adhan.service';
import { AdhanTimesDTO } from 'src/app/Adhan';

@Component({
  selector: 'app-adhan-container',
  templateUrl: './adhan-container.component.html',
  styleUrls: ['./adhan-container.component.css']
})
export class AdhanContainerComponent {

  currentAdhan!: AdhanTimesDTO;
  constructor(private adhanService: AdhanService) {}

  ngOnInit(): void {
    this.adhanService.getAdhan().subscribe(adhan => this.currentAdhan = adhan)
  }
}

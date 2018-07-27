import { Component, OnInit } from '@angular/core';
import { MakeService } from '../../Services/make.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {

    makes: any[];
    vehicle:any = {};
    models: any[];


    constructor(private makeService: MakeService) { }

    ngOnInit() {
        this.makeService.getMakes()
            .subscribe(makes => {
                this.makes = makes;
            });
    }

    getModels() {
        var selectedMake = this.makes.find(m => m.id == this.vehicle.make);
        console.log(selectedMake);
        this.models = selectedMake ? selectedMake.model : [];
    }

}

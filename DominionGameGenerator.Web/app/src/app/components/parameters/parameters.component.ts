import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup } from '@angular/forms';

import { Expansion } from '../../models/expansion';
import { ExpansionService } from '../../services/expansion.service';
import { GameService } from '../../services/game.service';
import { EventFrequencies, ParameterCollection } from '../../models/parameter-collection';

@Component({
  selector: 'parameters',
  templateUrl: './parameters.component.html',
  styleUrls: ['./parameters.component.scss'],
  providers: [ExpansionService]
})
export class ParametersComponent implements OnInit {

  parameterForm: FormGroup;
  expansionArray: FormArray = this.fb.array([]);
  eventFrequencies = EventFrequencies;
  expanded: boolean = false;

  constructor(private fb: FormBuilder,
              private expansionService: ExpansionService,
              private gameService: GameService) {
    this.createForm();
  }

  ngOnInit() {
    this.expansionService.expansions.subscribe(expansions => this.setExpansions(expansions));

    this.expansionService.updateExpansions();
  }

  setExpansions(expansions: Expansion[]) {
    const expansionFormGroups = expansions.map(expansion => this.fb.group(expansion));
    this.expansionArray = this.fb.array(expansionFormGroups);
    this.parameterForm.setControl('expansions', this.expansionArray);
  }

  createForm() {
    this.parameterForm = this.fb.group({
      expansions: this.fb.array([]),
      prosperityExpandedPercentage: 50,
      darkAgesShelterPercentage: 50,
      eventFrequency: EventFrequencies.Random
    });
  }

  submitForm() {
    let parameterCollection = this.prepareParameterCollection();

    this.gameService.updateGame(parameterCollection);
  }

  prepareParameterCollection() {
    const formModel = this.parameterForm.value;

    const expansionDeepCopy = formModel.expansions.map((expansion: Expansion) => Object.assign({}, expansion));

    const preparedParameters: ParameterCollection = {
      expansions: expansionDeepCopy,
      prosperityExpandedPercentage: Number(formModel.prosperityExpandedPercentage),
      darkAgesShelterPercentage: Number(formModel.darkAgesShelterPercentage),
      eventFrequency: formModel.eventFrequency as EventFrequencies
    };

    return preparedParameters;
  }

  toggleExpand() {
    this.expanded = !this.expanded;
  }

}

import { DominionCardChooserPage } from './app.po';

describe('dominion-card-chooser App', () => {
  let page: DominionCardChooserPage;

  beforeEach(() => {
    page = new DominionCardChooserPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

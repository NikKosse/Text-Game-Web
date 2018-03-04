import { TextGameFrontEndPage } from './app.po';

describe('text-game-front-end App', function() {
  let page: TextGameFrontEndPage;

  beforeEach(() => {
    page = new TextGameFrontEndPage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

import { MenuTemplatePage } from './app.po';

describe('Menu App', function() {
  let page: MenuTemplatePage;

  beforeEach(() => {
    page = new MenuTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});

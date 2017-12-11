import { NgxInterviewWebPage } from './app.po';

describe('ngx-interview-web App', () => {
  let page: NgxInterviewWebPage;

  beforeEach(() => {
    page = new NgxInterviewWebPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});

﻿namespace Encyclopedy
{
    class MainPage : MenuPage
    {
        
        public MainPage(Program program)
            : base("Main Page", program,
                  new Option("Sign In", () => program.NavigateTo<SignInPage>()),
                  new Option("Search Article", () => program.NavigateTo<MainSearchArticlePage>()),
                  new Option("Search User", () => program.NavigateTo<Page1Ai>()),
                  new Option("Input", () => program.NavigateTo<InputPage>()))
        {
        }
    }
}

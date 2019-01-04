#pragma checksum "C:\Users\Steven\Source\TwitterSentimentWebApp\TwitterSentimentWebApp.App\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaba3a46e7fcaa807f020706957ddaa1b601af91"
// <auto-generated/>
#pragma warning disable 1591
namespace TwitterSentimentWebApp.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using TwitterSentimentWebApp.App;
    using TwitterSentimentWebApp.App.Shared;
    using System.Text.RegularExpressions;
    using TwitterSentiment;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    [Microsoft.AspNetCore.Blazor.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.AddMarkupContent(0, "<div class=\"row mt-5\">\n    <div class=\"col-md-12\">\n        <h1 class=\"text-center text-muted\">\n            Twitter Sentiment Analysis\n        </h1>\n    </div>\n</div>\n");
            builder.OpenElement(1, "div");
            builder.AddAttribute(2, "class", "container");
            builder.AddMarkupContent(3, "\n    <br>\n    ");
            builder.OpenElement(4, "div");
            builder.AddAttribute(5, "class", "row justify-content-center");
            builder.AddContent(6, "\n        ");
            builder.OpenElement(7, "div");
            builder.AddAttribute(8, "class", "col-12 col-md-10 col-lg-8");
            builder.AddContent(9, "\n            ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "card card-sm");
            builder.AddContent(12, "\n                ");
            builder.OpenElement(13, "div");
            builder.AddAttribute(14, "class", "card-body row no-gutters align-items-center");
            builder.AddContent(15, "\n                    ");
            builder.AddMarkupContent(16, "<div class=\"col-auto\">\n                        <i class=\"fas fa-search h4 text-body\"></i>\n                    </div>\n                    \n                    ");
            builder.OpenElement(17, "div");
            builder.AddAttribute(18, "class", "col");
            builder.AddContent(19, "\n                        ");
            builder.OpenElement(20, "input");
            builder.AddAttribute(21, "class", "form-control" + " form-control-lg" + " form-control-borderless" + " " + (InputCssClass));
            builder.AddAttribute(22, "type", "search");
            builder.AddAttribute(23, "placeholder", "Enter twitter username");
            builder.AddAttribute(24, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(username));
            builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => username = __value, username));
            builder.CloseElement();
            builder.AddContent(26, "\n                    ");
            builder.CloseElement();
            builder.AddMarkupContent(27, "\n                    \n                    ");
            builder.OpenElement(28, "div");
            builder.AddAttribute(29, "class", "col-auto");
            builder.AddContent(30, "\n                        ");
            builder.OpenElement(31, "button");
            builder.AddAttribute(32, "class", "btn btn-lg btn-primary");
            builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(Search));
            builder.AddAttribute(34, "onkeypress", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIKeyboardEventArgs>(KeyPress));
            builder.AddContent(35, "Search");
            builder.CloseElement();
            builder.AddContent(36, "\n                    ");
            builder.CloseElement();
            builder.AddMarkupContent(37, "\n                    \n                ");
            builder.CloseElement();
            builder.AddContent(38, "\n            ");
            builder.CloseElement();
            builder.AddContent(39, "\n        ");
            builder.CloseElement();
            builder.AddMarkupContent(40, "\n        \n    ");
            builder.CloseElement();
            builder.AddContent(41, "\n    ");
            builder.OpenElement(42, "div");
            builder.AddAttribute(43, "class", "alert alert-danger");
            builder.AddAttribute(44, "role", "alert");
            builder.AddAttribute(45, "hidden", HideError);
            builder.AddContent(46, Error);
            builder.CloseElement();
            builder.AddContent(47, "\n    ");
            builder.OpenElement(48, "div");
            builder.AddAttribute(49, "class", "loader");
            builder.AddAttribute(50, "hidden", HideLoader);
            builder.AddContent(51, "Loading...");
            builder.CloseElement();
            builder.AddContent(52, "\n");
#line 39 "C:\Users\Steven\Source\TwitterSentimentWebApp\TwitterSentimentWebApp.App\Pages\Index.cshtml"
     if (TweetsLoaded && HideLoader)
    {

#line default
#line hidden
            builder.AddContent(53, "        ");
            builder.OpenElement(54, "div");
            builder.AddAttribute(55, "role", "alert");
            builder.AddAttribute(56, "class", "alert" + " alert-" + (GetSentimentText(@Average, true)) + " mt-5");
            builder.AddContent(57, "\n        Overall this timeline is ");
            builder.OpenElement(58, "strong");
            builder.AddContent(59, GetSentimentText(@Average));
            builder.CloseElement();
            builder.AddContent(60, "\n        ");
            builder.CloseElement();
            builder.AddContent(61, "\n        ");
            builder.OpenElement(62, "table");
            builder.AddAttribute(63, "class", "table mt-5");
            builder.AddContent(64, "\n            ");
            builder.OpenElement(65, "tbody");
            builder.AddContent(66, "\n");
#line 46 "C:\Users\Steven\Source\TwitterSentimentWebApp\TwitterSentimentWebApp.App\Pages\Index.cshtml"
                 foreach (var tweet in TweetSentiment)
                {

#line default
#line hidden
            builder.AddContent(67, "                    ");
            builder.OpenElement(68, "tr");
            builder.AddContent(69, "\n                        ");
            builder.OpenElement(70, "td");
            builder.AddContent(71, tweet.Text);
            builder.CloseElement();
            builder.AddContent(72, "\n                        ");
            builder.OpenElement(73, "td");
            builder.AddContent(74, "\n                            ");
            builder.OpenElement(75, "button");
            builder.AddAttribute(76, "type", "button");
            builder.AddAttribute(77, "class", "btn" + " btn-" + (GetSentimentText(@tweet.Score, true)) + " btn-block");
            builder.AddContent(78, GetSentimentText(@tweet.Score));
            builder.CloseElement();
            builder.AddContent(79, "\n                        ");
            builder.CloseElement();
            builder.AddContent(80, "\n                    ");
            builder.CloseElement();
            builder.AddContent(81, "\n");
#line 54 "C:\Users\Steven\Source\TwitterSentimentWebApp\TwitterSentimentWebApp.App\Pages\Index.cshtml"
                }

#line default
#line hidden
            builder.AddContent(82, "            ");
            builder.CloseElement();
            builder.AddContent(83, "\n        ");
            builder.CloseElement();
            builder.AddContent(84, "\n");
#line 57 "C:\Users\Steven\Source\TwitterSentimentWebApp\TwitterSentimentWebApp.App\Pages\Index.cshtml"
    }

#line default
#line hidden
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 59 "C:\Users\Steven\Source\TwitterSentimentWebApp\TwitterSentimentWebApp.App\Pages\Index.cshtml"
            
    IEnumerable<TweetsWithSentiment> TweetSentiment;
    bool TweetsLoaded => TweetSentiment != null;
    bool HideLoader = true;
    string username;
    double Average;

    string Error = "";
    bool HideError => String.IsNullOrWhiteSpace(Error); 
    string InputCssClass => HideError ? "" : "is-invalid"; 

    private async Task Search()
    {
        var isValid = IsUsernameValid(username);

        if(isValid)
        {
            await ToggleLoader();

            if(username != "demo")
                await DoSearch();
            else
                await DoDemoSearch();

            await ToggleLoader();
        }
        else
        {
           Error = "A username cannot be longer than 15 characters and contain only alphanumeric characters (letters A-Z, numbers 0-9) or underscores";
           await RefreshState();
        }
        
    }

    private async Task DoSearch()
    {
        var tweets = await twitterClient.GetTimeline(username);
        var sentiment = await analyticsClient.AnalyzeSentiment(tweets.ProjectToDocuments());

        TweetSentiment = tweets.Combine(sentiment);

        Average = TweetSentiment.Select(s=> s.Score).Average();
    }

    private async Task DoDemoSearch()
    {
       await Task.Delay(3000);

       TweetSentiment = new List<TweetsWithSentiment> {
            new TweetsWithSentiment("1", "Wholeschool is awesome!", 0.9),
            new TweetsWithSentiment("1", "Wholeschool staff are the best", 0.7),
            new TweetsWithSentiment("1", "Moodle is a great product", 0.6),
            new TweetsWithSentiment("1", "Wholeschool are a software company", 0.5),
            new TweetsWithSentiment("1", "NodeJs is pants!", 0.1),
        };

        Average = TweetSentiment.Select(s=> s.Score).Average();
    }

    private async Task ToggleLoader()
    {
       HideLoader = !HideLoader;
       base.StateHasChanged();
    }
    
    private async Task RefreshState()
    {
        base.StateHasChanged();
    }

    private bool IsUsernameValid(string username)
    {
        Error = "";

        if(string.IsNullOrWhiteSpace(username))
            return false;

        return new Regex(@"^@?(\w){1,15}$")
                .Match(username)
                .Success;
    }

    private string GetSentimentText(double score, bool isCssClass = false)
    {
        switch (score)
        {
            case var s when (s >= 0.8): return isCssClass ? "success" : "Very Positive";
            case var s when (s > 0.5): return isCssClass ? "success" : "Positive";
            case var s when (s == 0.5): return isCssClass ? "default" : "Neutral";
            case var s when (s <= 0.2): return isCssClass ? "danger" : "Very Negative";
            case var s when (s < 0.5): return isCssClass ? "danger" : "Negative";
            default: return isCssClass ? "success" : "default";
        }
    }

    async Task KeyPress(UIKeyboardEventArgs e)
    {
        Console.WriteLine("KEY:" + e.Key);
        if (e.Key == "Enter")
        {
            await Search();
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private TextAnalyticsClient analyticsClient { get; set; }
        [global::Microsoft.AspNetCore.Blazor.Components.InjectAttribute] private TwitterClient twitterClient { get; set; }
    }
}
#pragma warning restore 1591

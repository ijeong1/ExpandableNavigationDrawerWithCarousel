# Expandable NavigationDrawer with CarouselView in Xamarin Forms

# Demo
![demo](https://github.com/ijeong1/ExpandableNavigationDrawerWithCarousel/blob/main/demo.gif)

# How it works
Expanding Animation effect from startingHeight 50 to endingHeight 250
```
Action<double> callback = input => expandableNavigation.HeightRequest = input;
double startingHeight = 50;
double endingHeight = 250;
uint rate = 16;
uint length = 3000;
Easing easing = Easing.CubicOut;
expandableNavigation.Animate("invis", callback, startingHeight, endingHeight, rate, length, easing);
```

Shrinking Effect
```
Action<double> callback = input => expandableNavigation.HeightRequest = input;
double startingHeight = expandableNavigation.Height;
double endingHeight = 50;
uint rate = 16;
uint length = 3000;
Easing easing = Easing.CubicOut;
expandableNavigation.Animate("invis", callback, startingHeight, endingHeight, rate, length, easing);
```
Todo
Implment this as a custom control.

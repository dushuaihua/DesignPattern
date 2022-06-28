using DecoratorPattern;

IWatch watch = new Watch();


DateWatchDecorator decorator1 = new DateWatchDecorator(watch);
WeekWatchDecorator decorator2 = new WeekWatchDecorator(decorator1);
decorator2.MakeWatch();
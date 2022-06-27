using CompositePattern;

IComponent root = new ContainerComponent("root");

root.Add(new SingleComponent("level-1.1"));

IComponent level12 = new ContainerComponent("level-1.2");

for (int i = 0; i < 8; i++)
{
    level12.Add(new SingleComponent($"level-1.2.{i + 1}"));
}

root.Add(level12);
root.Add(new SingleComponent("level-1.3"));
root.Add(new SingleComponent("level-1.4"));

IComponent level15 = new ContainerComponent("level-1.5");

for (int i = 0; i < 3; i++)
{
    level15.Add(new SingleComponent($"level-1.5.{i + 1}"));
}

root.Add(level15);

root.Process(1);
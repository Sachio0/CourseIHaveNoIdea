using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectProgramming
{
    public class Example : ParentExample, IExample
    {

    }
    public class ParentExample : AbstractionExample
    {

    }
    public abstract class AbstractionExample : IAbstractionExample
    {

    }

    public interface IAbstractionExample
    {

    }
    public interface IExample
    {

    }

}

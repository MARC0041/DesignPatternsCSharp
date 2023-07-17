using System;

namespace DotNetDesignPatternDemos.SOLID.InterfaceSegregationPrinciple
{
    /*
     * Make sure unnecessary functionalities can be segregated! 
     * 1. Split it up into multiple interfaces: interface1, interface2
     * 2. Can combine if you want. combined_interface: interface1, interface2
     * 3. Implement the class. CombineClass : combined_interface
     *      contructor will need to take in multiple interfaces 
     *      CombineClass(interface1, interface2)...
     * 4. Use decorator pattern to call
     *     public void Print(Document d)
            {
              printer.Print(d);
            }
     * */

    public class Demo
    {
        public static void Main_(string[] args)
        {
            // Nothing to call
        }
    }
  public class Document
  {
  }

  public interface IMachine
  {
    void Print(Document d);
    void Fax(Document d);
    void Scan(Document d);
  }

  // ok if you need a multifunction machine
  public class MultiFunctionPrinter : IMachine
  {
    public void Print(Document d)
    {
      //
    }

    public void Fax(Document d)
    {
      //
    }

    public void Scan(Document d)
    {
      //
    }
  }

  public class OldFashionedPrinter : IMachine
  {
    public void Print(Document d)
    {
      // yep
    }

    public void Fax(Document d)
    {
      throw new System.NotImplementedException();
    }

    public void Scan(Document d)
    {
      throw new System.NotImplementedException();
    }
  }

  public interface IPrinter
  {
    void Print(Document d);
  }

  public interface IScanner
  {
    void Scan(Document d);
  }

  public class Printer : IPrinter
  {
    public void Print(Document d)
    {
      
    }
  }

  public class Photocopier : IPrinter, IScanner
  {
    public void Print(Document d)
    {
      throw new System.NotImplementedException();
    }

    public void Scan(Document d)
    {
      throw new System.NotImplementedException();
    }
  }

  public interface IMultiFunctionDevice : IPrinter, IScanner //
  {
    
  }

  public struct MultiFunctionMachine : IMultiFunctionDevice
  {
    // compose this out of several modules
    private IPrinter printer;
    private IScanner scanner;

    public MultiFunctionMachine(IPrinter printer, IScanner scanner)
    {
      if (printer == null)
      {
        throw new ArgumentNullException(paramName: nameof(printer));
      }
      if (scanner == null)
      {
        throw new ArgumentNullException(paramName: nameof(scanner));
      }
      this.printer = printer;
      this.scanner = scanner;
    }

    public void Print(Document d)
    {
      printer.Print(d);
    }

    public void Scan(Document d)
    {
      scanner.Scan(d);
    }
  }
}

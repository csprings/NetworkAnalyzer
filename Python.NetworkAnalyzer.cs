using Keysight.Plugins.Python;

[assembly: System.Reflection.AssemblyVersion("1.0.0.0")]
[assembly: System.Reflection.AssemblyFileVersion("1.0.0.0")]
[assembly: System.Reflection.AssemblyInformationalVersion("1.0.0.0")]
[assembly: System.Runtime.InteropServices.GuidAttribute("d112334e-6d5f-44c5-a09a-1ef70ae26e67")]
namespace Python.NetworkAnalyzer
{
 [PythonWrapper.PythonName("NetworkAnalyzer.VNA.VNA")]
 [OpenTap.DisplayAttribute("VNA", "add VNA Network Analyzer", "VNA")]
 public class VNA : Keysight.OpenTap.Plugins.Python.PythonInstrumentWrapper
 {
  public override void load_instance()
  {
   load("VNA", "NetworkAnalyzer");
  }

  [OpenTap.DisplayAttribute("VISA Address", "VISA Address of the instrument to connect", "VISA")]
  public System.String visa_address
  {
   get
   {
    return (System.String)this.getValue("visa_address", typeof(System.String));
   }

   set
   {
    this.setValue("visa_address", value);
   }
  }

  [OpenTap.DisplayAttribute("IO Timeout", "Timeout of the connection", "VISA")]
  [OpenTap.UnitAttribute("sec", PreScaling: 1000)]
  public System.Int32 io_timeout
  {
   get
   {
    return (System.Int32)this.getValue("io_timeout", typeof(System.Int32));
   }

   set
   {
    this.setValue("io_timeout", value);
   }
  }
 }

 [PythonWrapper.PythonName("NetworkAnalyzer.Reset.Reset")]
 [OpenTap.DisplayAttribute("Reset", "Reset the instrument to default setting", "VNA")]
 public class Reset : Keysight.OpenTap.Plugins.Python.PythonStepWrapper
 {
  public override void load_instance()
  {
   load("Reset", "NetworkAnalyzer");
  }

  [OpenTap.DisplayAttribute("Instrument", "The instrument to connect", "Resources")]
  public VNA vna
  {
   get
   {
    return (VNA)this.getValue("vna", typeof(VNA));
   }

   set
   {
    this.setValue("vna", value);
   }
  }
 }

 [PythonWrapper.PythonName("NetworkAnalyzer.SParameterTest.SParameterTest")]
 [OpenTap.DisplayAttribute("S-ParameterTest", "Sparameter Test", "VNA")]
 public class SParameterTest : Keysight.OpenTap.Plugins.Python.PythonStepWrapper
 {
  public override void load_instance()
  {
   load("SParameterTest", "NetworkAnalyzer");
  }

  [OpenTap.DisplayAttribute("Instrument", "The instrument to connect", "Resources", 1)]
  public VNA vna
  {
   get
   {
    return (VNA)this.getValue("vna", typeof(VNA));
   }

   set
   {
    this.setValue("vna", value);
   }
  }

  [OpenTap.DisplayAttribute("Channel", "Channel", "VNA Setup", 2)]
  public System.Int32 VnaChannel
  {
   get
   {
    return (System.Int32)this.getValue("VnaChannel", typeof(System.Int32));
   }

   set
   {
    this.setValue("VnaChannel", value);
   }
  }

  [OpenTap.DisplayAttribute("Window", "Window", "VNA Setup", 3)]
  public System.Int32 VnaWindow
  {
   get
   {
    return (System.Int32)this.getValue("VnaWindow", typeof(System.Int32));
   }

   set
   {
    this.setValue("VnaWindow", value);
   }
  }

  [OpenTap.DisplayAttribute("Start Frequency", "Start Frequency of the sweep", "VNA Setup", 4)]
  [OpenTap.UnitAttribute("Hz", UseEngineeringPrefix: true)]
  public System.Double StartFrequency
  {
   get
   {
    return (System.Double)this.getValue("StartFrequency", typeof(System.Double));
   }

   set
   {
    this.setValue("StartFrequency", value);
   }
  }

  [OpenTap.DisplayAttribute("Stop Frequency", "Stop Frequency of the sweep", "VNA Setup", 5)]
  [OpenTap.UnitAttribute("Hz")]
  public System.Double StopFrequency
  {
   get
   {
    return (System.Double)this.getValue("StopFrequency", typeof(System.Double));
   }

   set
   {
    this.setValue("StopFrequency", value);
   }
  }

  [OpenTap.DisplayAttribute("AutoScale", "Autoscale", "VNA Setup", 6)]
  public System.Boolean Autoscale
  {
   get
   {
    return (System.Boolean)this.getValue("Autoscale", typeof(System.Boolean));
   }

   set
   {
    this.setValue("Autoscale", value);
   }
  }

  [OpenTap.DisplayAttribute("Measurement Number", "Number for the Measurement", "Measurement", 8)]
  public System.Int32 MeasurementNum
  {
   get
   {
    return (System.Int32)this.getValue("MeasurementNum", typeof(System.Int32));
   }

   set
   {
    this.setValue("MeasurementNum", value);
   }
  }

  [OpenTap.DisplayAttribute("Measurement", "put S21, S11, S22, S12", "Measurement", 7)]
  public NetworkAnalyzer.Measurement Measure
  {
   get
   {
    return (NetworkAnalyzer.Measurement)this.getValue("Measure", typeof(NetworkAnalyzer.Measurement));
   }

   set
   {
    this.setValue("Measure", value);
   }
  }
 }

 [PythonWrapper.PythonName("NetworkAnalyzer.SaveImage.SaveImage")]
 [OpenTap.DisplayAttribute("Save Image", "Sparameter Test", "VNA")]
 public class SaveImage : Keysight.OpenTap.Plugins.Python.PythonStepWrapper
 {
  public override void load_instance()
  {
   load("SaveImage", "NetworkAnalyzer");
  }

  [OpenTap.DisplayAttribute("Instrument", "The instrument to connect", "Resources", 1)]
  public VNA vna
  {
   get
   {
    return (VNA)this.getValue("vna", typeof(VNA));
   }

   set
   {
    this.setValue("vna", value);
   }
  }

  [OpenTap.FilePathAttribute]
  [OpenTap.DisplayAttribute("Path", "The path to save the image", "Setup", 1)]
  public System.String ImagePath
  {
   get
   {
    return (System.String)this.getValue("ImagePath", typeof(System.String));
   }

   set
   {
    this.setValue("ImagePath", value);
   }
  }
 }

 [PythonWrapper.PythonName("NetworkAnalyzer.SParameterTest.Measurement")]
 public enum Measurement
 {
  [OpenTap.DisplayAttribute("S11", "Return loss of port 1")]
  S11 = 1,
  [OpenTap.DisplayAttribute("S21", "Insertion loss from port 1 to port 2")]
  S21 = 2,
  [OpenTap.DisplayAttribute("S22", "Return loss of port 2")]
  S22 = 3,
  [OpenTap.DisplayAttribute("S12", "Insertion loss from port 2 to port 1")]
  S12 = 4
 }
}
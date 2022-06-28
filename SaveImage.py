"""
 For more examples, please refer to the plugin example of OpenTAP Python plugin.
"""
import sys
import clr
import PythonTap
import OpenTap
import System
from PythonTap import *
from OpenTap import DisplayAttribute, UnitAttribute, Verdict
from System import String, Int32 # Import types to reference for generic methods.
from .VNA import *

@Attribute(DisplayAttribute, "Save Image", "Sparameter Test", "VNA")
class SaveImage(TestStep):
    def __init__(self):
        super(SaveImage, self).__init__()
        
        # ToDo: Add property here for each parameter the end user should be able to change.
        # AddProperty("property_name", default property value, property data type)

        # String property example.
        prop = self.AddProperty("vna", None, VNA)
        prop.AddAttribute(DisplayAttribute, "Instrument", "The instrument to connect", "Resources", 1)
        
        prop = self.AddProperty("ImagePath", "image.png", String)
        prop.AddAttribute(OpenTap.FilePathAttribute)
        prop.AddAttribute(DisplayAttribute, "Path", "The path to save the image", "Setup", 1)
        

    def Run(self):
        # ToDo: Add test case code.
        b = self.vna._io.ScpiQueryBlock("HCOPy:SDUMp:DATA?")
        newbinary = bytearray(b)
        with open(f"{self.ImagePath}", "wb") as image:
            image.write(newbinary)
        # If the step supports child steps, run the child steps.
        for step in self.EnabledChildSteps:
            self.RunChildStep(step)
        
        # If no verdict is specified, the default verdict will be NotSet.
        # Please change the verdict using UpgradeVerdict() as shown below.
        self.UpgradeVerdict(Verdict.NotSet)
        
        pass

    def PrePlanRun(self):
        # ToDo: Add test case code when the plan starts.
        
        pass

    def PostPlanRun(self):
        # ToDo: Add test case code when the plan completes.
        
        pass

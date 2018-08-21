1) Object Oriented Command pattern has been used. Please refer the UML diagram for high level understanding.

2) ICamera is the interface which is referred as a device and has its own behavior. If new Camera is launched, a new Camera
class can be created which inherits implements ICamera interface. And Client will have to pass a new Camera class object.
There will be no code changes as it is Interface driven design.

3) Client just passess the commands via Communication Channel to Camera without knowing the behavior.

4) Exception Handling: Checked if the Camera is object is null, throw the exception

5) Unit Test Project has been used and Moq is used as a test tool
 
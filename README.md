# myS7ProSimLib
Imported S7PROSimLib type library. To connect unity3D with Siemens PLCSim using COM Interop.

Using third party DLL in Unity3d Game Engine by Fernando Balandran
Lessons learned from trying to interact with a third party DLL in unity3d. I think that many of the links below would probably apply to other scenarios. Many videos online and tutorials talked about creating a DLL from scratch either c# or c++ none of which I needed. Very few talked about actually using a third party native DLL such as the one I needed from Siemens PLC.
The solution was actually quite easy after lots of trial and error, and many more reading through the forums and what not. I used tlbimp.exe to generate a type library DLL, then I placed that into the assets/plugins folder also note on unity3d editor properties that the new DLL is treated as managed code. Note that this particular DLL doesn’t work on 64bit Unity Editor and it threw a COMException. However the new type library DLL works fine in 32bit Unity Editor, I imagine that somewhere in the DLL there is an instruction specifying to work only in 32bit.
https://msdn.microsoft.com/en-us/library/ms973872.aspx [An Overview of Managed/Unmanaged Code Interoperability]
https://msdn.microsoft.com/en-us/library/42b9ea93%28v=vs.110%29.aspx?cs-save-lang=1&cs-lang=csharp#code-snippet-1 [Platform Invoke Examples]
https://msdn.microsoft.com/en-us/library/aa288468%28v=vs.71%29.aspx [Platform invoke tutorial]
http://www.codeproject.com/Articles/990/Understanding-Classic-COM-Interoperability-With-NE 
http://www.codeproject.com/Articles/14180/Using-Unmanaged-C-Libraries-DLLs-in-NET-Applicatio#Perform
https://msdn.microsoft.com/library/e753eftz%28v=vs.100%29.aspx [Customizing Runtime Callable Wrappers]
https://msdn.microsoft.com/en-us/library/eaw10et3%28v=vs.110%29.aspx [Interop Marshaling]
https://msdn.microsoft.com/en-us/library/9f9f3yxf%28v=vs.110%29.aspx [Marshaling Data with COM Interop]
https://msdn.microsoft.com/en-us/library/aa645736%28v=vs.71%29.aspx [COM Interop tutorial] Sample one is the one that lead me in the right direction.
There is also a very good book by Andrew Troelsen called COM and .NET Interoperability
Terms: Dynamic Linked Library (DLL), Platform Invoke, COM Interop, C++ Interop, Marshalling, DLLImport, InteropServices, 
Tools used: Unity3d 32bit and 64bit, Visual Studio 2015, tlbimpl.exe, Ildasm.exe, Visual Studio Develop Cmd Prompt
Conclusion: Youtube is full of “DLL” using and creating for unity3d use. Most are just creating classes, and methods and wrapping into a DLL mainly for repurposing. What worked for me was COM Interop, and I can create instances, and call methods with no issues. I didn’t have to re-write any methods or anything tlbimp.exe took care of all the heavy work. I hope the links help, and good luck!


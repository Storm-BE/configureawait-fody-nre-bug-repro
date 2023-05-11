Minimal reproduction of a bug with IL weaver ConfigureAwait.Fody

This fails with an exception like:
```
System.NullReferenceException: Object reference not set to an instance of an object.
   at System.Threading.Tasks.Task.AddTaskContinuationComplex(Object tc, Boolean addBeforeOthers)
   at System.Threading.Tasks.Task.AddTaskContinuation(Object tc, Boolean addBeforeOthers)
   at System.Threading.Tasks.Task.UnsafeSetContinuationForAwait(IAsyncStateMachineBox stateMachineBox, Boolean continueOnCapturedContext)
   at System.Runtime.CompilerServices.TaskAwaiter.UnsafeOnCompletedInternal(Task task, IAsyncStateMachineBox stateMachineBox, Boolean continueOnCapturedContext)
   at System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1.AwaitUnsafeOnCompleted[TAwaiter](TAwaiter& awaiter, IAsyncStateMachineBox box)
   at Program.<Main>$(String[] args) in C:\Repos\experiments\configureawait-fody-nre-bug-repro\Program.cs:line 3
   at Program.<Main>(String[] args)
```

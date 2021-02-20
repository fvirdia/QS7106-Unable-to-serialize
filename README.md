# QS7106-Unable-to-serialize
LowMC L5 Q# implementation that fails to compile under version 0.15 of the QDK.

To reproduce the error, run
```
cd qlowmc
dotnet build # this may take ~16 hours before it finally fails
```

Ideally, `qlowmc/` and `host/` should both build, and the latter should run.
Smaller LowMC circuits (taking ~8hrs of compile time) are correctly serialized, built and run.

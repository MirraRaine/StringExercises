// Validating benchmarks:
// ***** BenchmarkRunner: Start   *****
// ***** Found 6 benchmark(s) in total *****
// ***** Building 1 exe(s) in Parallel: Start   *****
// start dotnet  restore /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 /p:Deterministic=true /p:Optimize=true in E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\d18eb232-e6b0-47ad-8202-9833d80d0465
// command took 2.7 sec and exited with 0
// start dotnet  build -c Release --no-restore /p:UseSharedCompilation=false /p:BuildInParallel=false /m:1 /p:Deterministic=true /p:Optimize=true in E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\d18eb232-e6b0-47ad-8202-9833d80d0465
// command took 6.56 sec and exited with 0
// ***** Done, took 00:00:10 (10.93 sec)   *****
// Found 6 benchmarks:
//   StringBenchmarks.NoBuilder: DefaultJob
//   StringBenchmarks.Builder: DefaultJob
//   StringBenchmarks.PooledBuilder: DefaultJob
//   StringBenchmarks.StackAllocated: DefaultJob
//   StringBenchmarks.ArrayPool: DefaultJob
//   StringBenchmarks.StringCreate: DefaultJob

Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: StringBenchmarks.NoBuilder: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet d18eb232-e6b0-47ad-8202-9833d80d0465.dll --anonymousPipes 2356 2364 --benchmarkName StringAllocationApp.StringBenchmarks.NoBuilder --job Default --benchmarkId 0 in E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\d18eb232-e6b0-47ad-8202-9833d80d0465\bin\Release\net5.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 378600.00 ns, 378.6000 us/op
WorkloadJitting  1: 1 op, 1977500.00 ns, 1.9775 ms/op

OverheadJitting  2: 16 op, 285200.00 ns, 17.8250 us/op
WorkloadJitting  2: 16 op, 11999100.00 ns, 749.9438 us/op

WorkloadPilot    1: 16 op, 11878300.00 ns, 742.3937 us/op
WorkloadPilot    2: 32 op, 22354700.00 ns, 698.5844 us/op
WorkloadPilot    3: 64 op, 49237800.00 ns, 769.3406 us/op
WorkloadPilot    4: 128 op, 76822500.00 ns, 600.1758 us/op
WorkloadPilot    5: 256 op, 159139500.00 ns, 621.6387 us/op
WorkloadPilot    6: 512 op, 271824600.00 ns, 530.9074 us/op
WorkloadPilot    7: 1024 op, 574512500.00 ns, 561.0474 us/op

OverheadWarmup   1: 1024 op, 3800.00 ns, 3.7109 ns/op
OverheadWarmup   2: 1024 op, 11800.00 ns, 11.5234 ns/op
OverheadWarmup   3: 1024 op, 3300.00 ns, 3.2227 ns/op
OverheadWarmup   4: 1024 op, 3400.00 ns, 3.3203 ns/op
OverheadWarmup   5: 1024 op, 3400.00 ns, 3.3203 ns/op

OverheadActual   1: 1024 op, 3700.00 ns, 3.6133 ns/op
OverheadActual   2: 1024 op, 5100.00 ns, 4.9805 ns/op
OverheadActual   3: 1024 op, 3500.00 ns, 3.4180 ns/op
OverheadActual   4: 1024 op, 3600.00 ns, 3.5156 ns/op
OverheadActual   5: 1024 op, 4600.00 ns, 4.4922 ns/op
OverheadActual   6: 1024 op, 3400.00 ns, 3.3203 ns/op
OverheadActual   7: 1024 op, 7000.00 ns, 6.8359 ns/op
OverheadActual   8: 1024 op, 4500.00 ns, 4.3945 ns/op
OverheadActual   9: 1024 op, 3800.00 ns, 3.7109 ns/op
OverheadActual  10: 1024 op, 3300.00 ns, 3.2227 ns/op
OverheadActual  11: 1024 op, 3000.00 ns, 2.9297 ns/op
OverheadActual  12: 1024 op, 3200.00 ns, 3.1250 ns/op
OverheadActual  13: 1024 op, 3200.00 ns, 3.1250 ns/op
OverheadActual  14: 1024 op, 3100.00 ns, 3.0273 ns/op
OverheadActual  15: 1024 op, 3000.00 ns, 2.9297 ns/op
OverheadActual  16: 1024 op, 3000.00 ns, 2.9297 ns/op
OverheadActual  17: 1024 op, 3000.00 ns, 2.9297 ns/op
OverheadActual  18: 1024 op, 3200.00 ns, 3.1250 ns/op
OverheadActual  19: 1024 op, 3000.00 ns, 2.9297 ns/op
OverheadActual  20: 1024 op, 3100.00 ns, 3.0273 ns/op

WorkloadWarmup   1: 1024 op, 599084900.00 ns, 585.0438 us/op
WorkloadWarmup   2: 1024 op, 552608600.00 ns, 539.6568 us/op
WorkloadWarmup   3: 1024 op, 606209300.00 ns, 592.0013 us/op
WorkloadWarmup   4: 1024 op, 558294200.00 ns, 545.2092 us/op
WorkloadWarmup   5: 1024 op, 563205000.00 ns, 550.0049 us/op
WorkloadWarmup   6: 1024 op, 557477900.00 ns, 544.4120 us/op

// BeforeActualRun
WorkloadActual   1: 1024 op, 552907400.00 ns, 539.9486 us/op
WorkloadActual   2: 1024 op, 554255100.00 ns, 541.2647 us/op
WorkloadActual   3: 1024 op, 551078100.00 ns, 538.1622 us/op
WorkloadActual   4: 1024 op, 559056600.00 ns, 545.9537 us/op
WorkloadActual   5: 1024 op, 553626100.00 ns, 540.6505 us/op
WorkloadActual   6: 1024 op, 546299300.00 ns, 533.4954 us/op
WorkloadActual   7: 1024 op, 564605300.00 ns, 551.3724 us/op
WorkloadActual   8: 1024 op, 551224100.00 ns, 538.3048 us/op
WorkloadActual   9: 1024 op, 588610400.00 ns, 574.8148 us/op
WorkloadActual  10: 1024 op, 575549500.00 ns, 562.0601 us/op
WorkloadActual  11: 1024 op, 549544100.00 ns, 536.6642 us/op
WorkloadActual  12: 1024 op, 559914900.00 ns, 546.7919 us/op
WorkloadActual  13: 1024 op, 544096300.00 ns, 531.3440 us/op
WorkloadActual  14: 1024 op, 551384500.00 ns, 538.4614 us/op
WorkloadActual  15: 1024 op, 565502900.00 ns, 552.2489 us/op

// AfterActualRun
WorkloadResult   1: 1024 op, 552904150.00 ns, 539.9455 us/op
WorkloadResult   2: 1024 op, 554251850.00 ns, 541.2616 us/op
WorkloadResult   3: 1024 op, 551074850.00 ns, 538.1590 us/op
WorkloadResult   4: 1024 op, 559053350.00 ns, 545.9505 us/op
WorkloadResult   5: 1024 op, 553622850.00 ns, 540.6473 us/op
WorkloadResult   6: 1024 op, 546296050.00 ns, 533.4922 us/op
WorkloadResult   7: 1024 op, 564602050.00 ns, 551.3692 us/op
WorkloadResult   8: 1024 op, 551220850.00 ns, 538.3016 us/op
WorkloadResult   9: 1024 op, 575546250.00 ns, 562.0569 us/op
WorkloadResult  10: 1024 op, 549540850.00 ns, 536.6610 us/op
WorkloadResult  11: 1024 op, 559911650.00 ns, 546.7887 us/op
WorkloadResult  12: 1024 op, 544093050.00 ns, 531.3409 us/op
WorkloadResult  13: 1024 op, 551381250.00 ns, 538.4583 us/op
WorkloadResult  14: 1024 op, 565499650.00 ns, 552.2458 us/op
// GC:  2180 0 0 4561305848 1024
// Threading:  2 0 1024

// AfterAll
// Benchmark Process 2660 has exited with code 0.

Mean = 542.620 us, StdErr = 2.212 us (0.41%), N = 14, StdDev = 8.275 us
Min = 531.341 us, Q1 = 538.195 us, Median = 540.296 us, Q3 = 546.579 us, Max = 562.057 us
IQR = 8.384 us, LowerFence = 525.618 us, UpperFence = 559.156 us
ConfidenceInterval = [533.285 us; 551.955 us] (CI 99.9%), Margin = 9.335 us (1.72% of Mean)
Skewness = 0.8, Kurtosis = 2.79, MValue = 2

// ** Remained 5 (83.3%) benchmark(s) to run. Estimated finish 2024-03-31 16:22 (0h 1m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: StringBenchmarks.Builder: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet d18eb232-e6b0-47ad-8202-9833d80d0465.dll --anonymousPipes 2276 2272 --benchmarkName StringAllocationApp.StringBenchmarks.Builder --job Default --benchmarkId 1 in E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\d18eb232-e6b0-47ad-8202-9833d80d0465\bin\Release\net5.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 320200.00 ns, 320.2000 us/op
WorkloadJitting  1: 1 op, 592700.00 ns, 592.7000 us/op

OverheadJitting  2: 16 op, 279700.00 ns, 17.4812 us/op
WorkloadJitting  2: 16 op, 3072800.00 ns, 192.0500 us/op

WorkloadPilot    1: 16 op, 1365500.00 ns, 85.3438 us/op
WorkloadPilot    2: 32 op, 2702900.00 ns, 84.4656 us/op
WorkloadPilot    3: 64 op, 9443700.00 ns, 147.5578 us/op
WorkloadPilot    4: 128 op, 13332500.00 ns, 104.1602 us/op
WorkloadPilot    5: 256 op, 24390500.00 ns, 95.2754 us/op
WorkloadPilot    6: 512 op, 45355100.00 ns, 88.5842 us/op
WorkloadPilot    7: 1024 op, 101995500.00 ns, 99.6050 us/op
WorkloadPilot    8: 2048 op, 166794100.00 ns, 81.4424 us/op
WorkloadPilot    9: 4096 op, 333372300.00 ns, 81.3897 us/op
WorkloadPilot   10: 8192 op, 685612500.00 ns, 83.6929 us/op

OverheadWarmup   1: 8192 op, 34500.00 ns, 4.2114 ns/op
OverheadWarmup   2: 8192 op, 34000.00 ns, 4.1504 ns/op
OverheadWarmup   3: 8192 op, 23100.00 ns, 2.8198 ns/op
OverheadWarmup   4: 8192 op, 23200.00 ns, 2.8320 ns/op
OverheadWarmup   5: 8192 op, 40100.00 ns, 4.8950 ns/op
OverheadWarmup   6: 8192 op, 32800.00 ns, 4.0039 ns/op
OverheadWarmup   7: 8192 op, 35500.00 ns, 4.3335 ns/op
OverheadWarmup   8: 8192 op, 41000.00 ns, 5.0049 ns/op
OverheadWarmup   9: 8192 op, 38700.00 ns, 4.7241 ns/op

OverheadActual   1: 8192 op, 33000.00 ns, 4.0283 ns/op
OverheadActual   2: 8192 op, 36400.00 ns, 4.4434 ns/op
OverheadActual   3: 8192 op, 23700.00 ns, 2.8931 ns/op
OverheadActual   4: 8192 op, 35400.00 ns, 4.3213 ns/op
OverheadActual   5: 8192 op, 23600.00 ns, 2.8809 ns/op
OverheadActual   6: 8192 op, 32100.00 ns, 3.9185 ns/op
OverheadActual   7: 8192 op, 23300.00 ns, 2.8442 ns/op
OverheadActual   8: 8192 op, 24600.00 ns, 3.0029 ns/op
OverheadActual   9: 8192 op, 33400.00 ns, 4.0771 ns/op
OverheadActual  10: 8192 op, 23500.00 ns, 2.8687 ns/op
OverheadActual  11: 8192 op, 23200.00 ns, 2.8320 ns/op
OverheadActual  12: 8192 op, 23400.00 ns, 2.8564 ns/op
OverheadActual  13: 8192 op, 23400.00 ns, 2.8564 ns/op
OverheadActual  14: 8192 op, 23300.00 ns, 2.8442 ns/op
OverheadActual  15: 8192 op, 23400.00 ns, 2.8564 ns/op
OverheadActual  16: 8192 op, 24000.00 ns, 2.9297 ns/op
OverheadActual  17: 8192 op, 24100.00 ns, 2.9419 ns/op
OverheadActual  18: 8192 op, 23800.00 ns, 2.9053 ns/op
OverheadActual  19: 8192 op, 32600.00 ns, 3.9795 ns/op
OverheadActual  20: 8192 op, 34900.00 ns, 4.2603 ns/op

WorkloadWarmup   1: 8192 op, 766954900.00 ns, 93.6224 us/op
WorkloadWarmup   2: 8192 op, 658772700.00 ns, 80.4166 us/op
WorkloadWarmup   3: 8192 op, 665822700.00 ns, 81.2772 us/op
WorkloadWarmup   4: 8192 op, 724439700.00 ns, 88.4326 us/op
WorkloadWarmup   5: 8192 op, 667046800.00 ns, 81.4266 us/op
WorkloadWarmup   6: 8192 op, 670486900.00 ns, 81.8465 us/op
WorkloadWarmup   7: 8192 op, 692251400.00 ns, 84.5033 us/op
WorkloadWarmup   8: 8192 op, 678992500.00 ns, 82.8848 us/op

// BeforeActualRun
WorkloadActual   1: 8192 op, 686998200.00 ns, 83.8621 us/op
WorkloadActual   2: 8192 op, 667698600.00 ns, 81.5062 us/op
WorkloadActual   3: 8192 op, 661855200.00 ns, 80.7929 us/op
WorkloadActual   4: 8192 op, 658161300.00 ns, 80.3420 us/op
WorkloadActual   5: 8192 op, 683345200.00 ns, 83.4162 us/op
WorkloadActual   6: 8192 op, 663507800.00 ns, 80.9946 us/op
WorkloadActual   7: 8192 op, 681393300.00 ns, 83.1779 us/op
WorkloadActual   8: 8192 op, 667622500.00 ns, 81.4969 us/op
WorkloadActual   9: 8192 op, 699088900.00 ns, 85.3380 us/op
WorkloadActual  10: 8192 op, 665850000.00 ns, 81.2805 us/op
WorkloadActual  11: 8192 op, 683909500.00 ns, 83.4850 us/op
WorkloadActual  12: 8192 op, 668384800.00 ns, 81.5899 us/op
WorkloadActual  13: 8192 op, 676352000.00 ns, 82.5625 us/op
WorkloadActual  14: 8192 op, 673544700.00 ns, 82.2198 us/op
WorkloadActual  15: 8192 op, 673683400.00 ns, 82.2367 us/op

// AfterActualRun
WorkloadResult   1: 8192 op, 686974300.00 ns, 83.8592 us/op
WorkloadResult   2: 8192 op, 667674700.00 ns, 81.5033 us/op
WorkloadResult   3: 8192 op, 661831300.00 ns, 80.7900 us/op
WorkloadResult   4: 8192 op, 658137400.00 ns, 80.3390 us/op
WorkloadResult   5: 8192 op, 683321300.00 ns, 83.4132 us/op
WorkloadResult   6: 8192 op, 663483900.00 ns, 80.9917 us/op
WorkloadResult   7: 8192 op, 681369400.00 ns, 83.1750 us/op
WorkloadResult   8: 8192 op, 667598600.00 ns, 81.4940 us/op
WorkloadResult   9: 8192 op, 699065000.00 ns, 85.3351 us/op
WorkloadResult  10: 8192 op, 665826100.00 ns, 81.2776 us/op
WorkloadResult  11: 8192 op, 683885600.00 ns, 83.4821 us/op
WorkloadResult  12: 8192 op, 668360900.00 ns, 81.5870 us/op
WorkloadResult  13: 8192 op, 676328100.00 ns, 82.5596 us/op
WorkloadResult  14: 8192 op, 673520800.00 ns, 82.2169 us/op
WorkloadResult  15: 8192 op, 673659500.00 ns, 82.2338 us/op
// GC:  1505 0 0 3152281848 8192
// Threading:  2 0 8192

// AfterAll
// Benchmark Process 15340 has exited with code 0.

Mean = 82.284 us, StdErr = 0.350 us (0.43%), N = 15, StdDev = 1.357 us
Min = 80.339 us, Q1 = 81.386 us, Median = 82.217 us, Q3 = 83.294 us, Max = 85.335 us
IQR = 1.908 us, LowerFence = 78.523 us, UpperFence = 86.157 us
ConfidenceInterval = [80.833 us; 83.735 us] (CI 99.9%), Margin = 1.451 us (1.76% of Mean)
Skewness = 0.56, Kurtosis = 2.38, MValue = 2

// ** Remained 4 (66.7%) benchmark(s) to run. Estimated finish 2024-03-31 16:23 (0h 1m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: StringBenchmarks.PooledBuilder: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet d18eb232-e6b0-47ad-8202-9833d80d0465.dll --anonymousPipes 912 2132 --benchmarkName StringAllocationApp.StringBenchmarks.PooledBuilder --job Default --benchmarkId 2 in E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\d18eb232-e6b0-47ad-8202-9833d80d0465\bin\Release\net5.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 351300.00 ns, 351.3000 us/op
WorkloadJitting  1: 1 op, 58031500.00 ns, 58.0315 ms/op

WorkloadPilot    1: 2 op, 215100.00 ns, 107.5500 us/op
WorkloadPilot    2: 3 op, 417200.00 ns, 139.0667 us/op
WorkloadPilot    3: 4 op, 350800.00 ns, 87.7000 us/op
WorkloadPilot    4: 5 op, 391600.00 ns, 78.3200 us/op
WorkloadPilot    5: 6 op, 449500.00 ns, 74.9167 us/op
WorkloadPilot    6: 7 op, 511900.00 ns, 73.1286 us/op
WorkloadPilot    7: 8 op, 1010800.00 ns, 126.3500 us/op
WorkloadPilot    8: 9 op, 900500.00 ns, 100.0556 us/op
WorkloadPilot    9: 10 op, 718200.00 ns, 71.8200 us/op
WorkloadPilot   10: 11 op, 1072500.00 ns, 97.5000 us/op
WorkloadPilot   11: 12 op, 1200000.00 ns, 100.0000 us/op
WorkloadPilot   12: 13 op, 1032000.00 ns, 79.3846 us/op
WorkloadPilot   13: 14 op, 1065200.00 ns, 76.0857 us/op
WorkloadPilot   14: 15 op, 1129600.00 ns, 75.3067 us/op
WorkloadPilot   15: 16 op, 1104300.00 ns, 69.0187 us/op
WorkloadPilot   16: 32 op, 4010900.00 ns, 125.3406 us/op
WorkloadPilot   17: 64 op, 5450100.00 ns, 85.1578 us/op
WorkloadPilot   18: 128 op, 12228900.00 ns, 95.5383 us/op
WorkloadPilot   19: 256 op, 21207100.00 ns, 82.8402 us/op
WorkloadPilot   20: 512 op, 51784000.00 ns, 101.1406 us/op
WorkloadPilot   21: 1024 op, 80016400.00 ns, 78.1410 us/op
WorkloadPilot   22: 2048 op, 155469800.00 ns, 75.9130 us/op
WorkloadPilot   23: 4096 op, 274810300.00 ns, 67.0924 us/op
WorkloadPilot   24: 8192 op, 539978100.00 ns, 65.9153 us/op

WorkloadWarmup   1: 8192 op, 579124800.00 ns, 70.6939 us/op
WorkloadWarmup   2: 8192 op, 570588500.00 ns, 69.6519 us/op
WorkloadWarmup   3: 8192 op, 530860200.00 ns, 64.8023 us/op
WorkloadWarmup   4: 8192 op, 559822900.00 ns, 68.3378 us/op
WorkloadWarmup   5: 8192 op, 543227600.00 ns, 66.3120 us/op
WorkloadWarmup   6: 8192 op, 533431400.00 ns, 65.1161 us/op
WorkloadWarmup   7: 8192 op, 558645900.00 ns, 68.1941 us/op
WorkloadWarmup   8: 8192 op, 552759300.00 ns, 67.4755 us/op

// BeforeActualRun
WorkloadActual   1: 8192 op, 576902200.00 ns, 70.4226 us/op
WorkloadActual   2: 8192 op, 548165000.00 ns, 66.9147 us/op
WorkloadActual   3: 8192 op, 545941800.00 ns, 66.6433 us/op
WorkloadActual   4: 8192 op, 576482700.00 ns, 70.3714 us/op
WorkloadActual   5: 8192 op, 540069300.00 ns, 65.9264 us/op
WorkloadActual   6: 8192 op, 559915200.00 ns, 68.3490 us/op
WorkloadActual   7: 8192 op, 556111700.00 ns, 67.8847 us/op
WorkloadActual   8: 8192 op, 542154600.00 ns, 66.1810 us/op
WorkloadActual   9: 8192 op, 559510600.00 ns, 68.2996 us/op
WorkloadActual  10: 8192 op, 552315300.00 ns, 67.4213 us/op
WorkloadActual  11: 8192 op, 576307300.00 ns, 70.3500 us/op
WorkloadActual  12: 8192 op, 545585900.00 ns, 66.5998 us/op
WorkloadActual  13: 8192 op, 571133000.00 ns, 69.7184 us/op
WorkloadActual  14: 8192 op, 557046500.00 ns, 67.9988 us/op
WorkloadActual  15: 8192 op, 546431500.00 ns, 66.7031 us/op
WorkloadActual  16: 8192 op, 538741900.00 ns, 65.7644 us/op
WorkloadActual  17: 8192 op, 560811900.00 ns, 68.4585 us/op
WorkloadActual  18: 8192 op, 538863500.00 ns, 65.7792 us/op
WorkloadActual  19: 8192 op, 565787800.00 ns, 69.0659 us/op
WorkloadActual  20: 8192 op, 549252900.00 ns, 67.0475 us/op

// AfterActualRun
WorkloadResult   1: 8192 op, 576902200.00 ns, 70.4226 us/op
WorkloadResult   2: 8192 op, 548165000.00 ns, 66.9147 us/op
WorkloadResult   3: 8192 op, 545941800.00 ns, 66.6433 us/op
WorkloadResult   4: 8192 op, 576482700.00 ns, 70.3714 us/op
WorkloadResult   5: 8192 op, 540069300.00 ns, 65.9264 us/op
WorkloadResult   6: 8192 op, 559915200.00 ns, 68.3490 us/op
WorkloadResult   7: 8192 op, 556111700.00 ns, 67.8847 us/op
WorkloadResult   8: 8192 op, 542154600.00 ns, 66.1810 us/op
WorkloadResult   9: 8192 op, 559510600.00 ns, 68.2996 us/op
WorkloadResult  10: 8192 op, 552315300.00 ns, 67.4213 us/op
WorkloadResult  11: 8192 op, 576307300.00 ns, 70.3500 us/op
WorkloadResult  12: 8192 op, 545585900.00 ns, 66.5998 us/op
WorkloadResult  13: 8192 op, 571133000.00 ns, 69.7184 us/op
WorkloadResult  14: 8192 op, 557046500.00 ns, 67.9988 us/op
WorkloadResult  15: 8192 op, 546431500.00 ns, 66.7031 us/op
WorkloadResult  16: 8192 op, 538741900.00 ns, 65.7644 us/op
WorkloadResult  17: 8192 op, 560811900.00 ns, 68.4585 us/op
WorkloadResult  18: 8192 op, 538863500.00 ns, 65.7792 us/op
WorkloadResult  19: 8192 op, 565787800.00 ns, 69.0659 us/op
WorkloadResult  20: 8192 op, 549252900.00 ns, 67.0475 us/op
// GC:  702 0 0 1470365944 8192
// Threading:  2 0 8192

// AfterAll
// Benchmark Process 16484 has exited with code 0.

Mean = 67.795 us, StdErr = 0.348 us (0.51%), N = 20, StdDev = 1.558 us
Min = 65.764 us, Q1 = 66.632 us, Median = 67.653 us, Q3 = 68.610 us, Max = 70.423 us
IQR = 1.978 us, LowerFence = 63.666 us, UpperFence = 71.577 us
ConfidenceInterval = [66.442 us; 69.148 us] (CI 99.9%), Margin = 1.353 us (2.00% of Mean)
Skewness = 0.38, Kurtosis = 1.78, MValue = 2

// ** Remained 3 (50.0%) benchmark(s) to run. Estimated finish 2024-03-31 16:23 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: StringBenchmarks.StackAllocated: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet d18eb232-e6b0-47ad-8202-9833d80d0465.dll --anonymousPipes 2300 2320 --benchmarkName StringAllocationApp.StringBenchmarks.StackAllocated --job Default --benchmarkId 3 in E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\d18eb232-e6b0-47ad-8202-9833d80d0465\bin\Release\net5.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 356600.00 ns, 356.6000 us/op
WorkloadJitting  1: 1 op, 2353300.00 ns, 2.3533 ms/op

OverheadJitting  2: 16 op, 421100.00 ns, 26.3188 us/op
WorkloadJitting  2: 16 op, 1937400.00 ns, 121.0875 us/op

WorkloadPilot    1: 16 op, 885800.00 ns, 55.3625 us/op
WorkloadPilot    2: 32 op, 2259600.00 ns, 70.6125 us/op
WorkloadPilot    3: 64 op, 5756300.00 ns, 89.9422 us/op
WorkloadPilot    4: 128 op, 7697700.00 ns, 60.1383 us/op
WorkloadPilot    5: 256 op, 17469000.00 ns, 68.2383 us/op
WorkloadPilot    6: 512 op, 34302900.00 ns, 66.9979 us/op
WorkloadPilot    7: 1024 op, 61081100.00 ns, 59.6495 us/op
WorkloadPilot    8: 2048 op, 128196500.00 ns, 62.5959 us/op
WorkloadPilot    9: 4096 op, 234158100.00 ns, 57.1675 us/op
WorkloadPilot   10: 8192 op, 455933000.00 ns, 55.6559 us/op
WorkloadPilot   11: 16384 op, 911366200.00 ns, 55.6254 us/op

OverheadWarmup   1: 16384 op, 41600.00 ns, 2.5391 ns/op
OverheadWarmup   2: 16384 op, 40300.00 ns, 2.4597 ns/op
OverheadWarmup   3: 16384 op, 40200.00 ns, 2.4536 ns/op
OverheadWarmup   4: 16384 op, 40300.00 ns, 2.4597 ns/op
OverheadWarmup   5: 16384 op, 40700.00 ns, 2.4841 ns/op
OverheadWarmup   6: 16384 op, 66200.00 ns, 4.0405 ns/op
OverheadWarmup   7: 16384 op, 63600.00 ns, 3.8818 ns/op
OverheadWarmup   8: 16384 op, 70400.00 ns, 4.2969 ns/op
OverheadWarmup   9: 16384 op, 122400.00 ns, 7.4707 ns/op
OverheadWarmup  10: 16384 op, 65900.00 ns, 4.0222 ns/op

OverheadActual   1: 16384 op, 56600.00 ns, 3.4546 ns/op
OverheadActual   2: 16384 op, 40400.00 ns, 2.4658 ns/op
OverheadActual   3: 16384 op, 60600.00 ns, 3.6987 ns/op
OverheadActual   4: 16384 op, 40500.00 ns, 2.4719 ns/op
OverheadActual   5: 16384 op, 45000.00 ns, 2.7466 ns/op
OverheadActual   6: 16384 op, 66300.00 ns, 4.0466 ns/op
OverheadActual   7: 16384 op, 52000.00 ns, 3.1738 ns/op
OverheadActual   8: 16384 op, 40300.00 ns, 2.4597 ns/op
OverheadActual   9: 16384 op, 40300.00 ns, 2.4597 ns/op
OverheadActual  10: 16384 op, 40300.00 ns, 2.4597 ns/op
OverheadActual  11: 16384 op, 40600.00 ns, 2.4780 ns/op
OverheadActual  12: 16384 op, 51800.00 ns, 3.1616 ns/op
OverheadActual  13: 16384 op, 79200.00 ns, 4.8340 ns/op
OverheadActual  14: 16384 op, 69100.00 ns, 4.2175 ns/op
OverheadActual  15: 16384 op, 62200.00 ns, 3.7964 ns/op
OverheadActual  16: 16384 op, 44700.00 ns, 2.7283 ns/op
OverheadActual  17: 16384 op, 44500.00 ns, 2.7161 ns/op
OverheadActual  18: 16384 op, 44900.00 ns, 2.7405 ns/op
OverheadActual  19: 16384 op, 86900.00 ns, 5.3040 ns/op
OverheadActual  20: 16384 op, 70600.00 ns, 4.3091 ns/op

WorkloadWarmup   1: 16384 op, 969110800.00 ns, 59.1498 us/op
WorkloadWarmup   2: 16384 op, 894535300.00 ns, 54.5981 us/op
WorkloadWarmup   3: 16384 op, 919034700.00 ns, 56.0934 us/op
WorkloadWarmup   4: 16384 op, 933763200.00 ns, 56.9924 us/op
WorkloadWarmup   5: 16384 op, 917382600.00 ns, 55.9926 us/op
WorkloadWarmup   6: 16384 op, 916431800.00 ns, 55.9346 us/op
WorkloadWarmup   7: 16384 op, 921097600.00 ns, 56.2193 us/op
WorkloadWarmup   8: 16384 op, 915676900.00 ns, 55.8885 us/op

// BeforeActualRun
WorkloadActual   1: 16384 op, 942530100.00 ns, 57.5275 us/op
WorkloadActual   2: 16384 op, 896100100.00 ns, 54.6936 us/op
WorkloadActual   3: 16384 op, 938004200.00 ns, 57.2512 us/op
WorkloadActual   4: 16384 op, 916789300.00 ns, 55.9564 us/op
WorkloadActual   5: 16384 op, 901538600.00 ns, 55.0255 us/op
WorkloadActual   6: 16384 op, 899452700.00 ns, 54.8982 us/op
WorkloadActual   7: 16384 op, 923354800.00 ns, 56.3571 us/op
WorkloadActual   8: 16384 op, 914155600.00 ns, 55.7956 us/op
WorkloadActual   9: 16384 op, 961685700.00 ns, 58.6966 us/op
WorkloadActual  10: 16384 op, 923963700.00 ns, 56.3943 us/op
WorkloadActual  11: 16384 op, 900382600.00 ns, 54.9550 us/op
WorkloadActual  12: 16384 op, 929666300.00 ns, 56.7423 us/op
WorkloadActual  13: 16384 op, 924578800.00 ns, 56.4318 us/op
WorkloadActual  14: 16384 op, 916991500.00 ns, 55.9687 us/op
WorkloadActual  15: 16384 op, 943221800.00 ns, 57.5697 us/op
WorkloadActual  16: 16384 op, 943003000.00 ns, 57.5563 us/op
WorkloadActual  17: 16384 op, 902356900.00 ns, 55.0755 us/op
WorkloadActual  18: 16384 op, 944637600.00 ns, 57.6561 us/op

// AfterActualRun
WorkloadResult   1: 16384 op, 942481700.00 ns, 57.5245 us/op
WorkloadResult   2: 16384 op, 896051700.00 ns, 54.6907 us/op
WorkloadResult   3: 16384 op, 937955800.00 ns, 57.2483 us/op
WorkloadResult   4: 16384 op, 916740900.00 ns, 55.9534 us/op
WorkloadResult   5: 16384 op, 901490200.00 ns, 55.0226 us/op
WorkloadResult   6: 16384 op, 899404300.00 ns, 54.8953 us/op
WorkloadResult   7: 16384 op, 923306400.00 ns, 56.3542 us/op
WorkloadResult   8: 16384 op, 914107200.00 ns, 55.7927 us/op
WorkloadResult   9: 16384 op, 961637300.00 ns, 58.6937 us/op
WorkloadResult  10: 16384 op, 923915300.00 ns, 56.3913 us/op
WorkloadResult  11: 16384 op, 900334200.00 ns, 54.9520 us/op
WorkloadResult  12: 16384 op, 929617900.00 ns, 56.7394 us/op
WorkloadResult  13: 16384 op, 924530400.00 ns, 56.4289 us/op
WorkloadResult  14: 16384 op, 916943100.00 ns, 55.9658 us/op
WorkloadResult  15: 16384 op, 943173400.00 ns, 57.5667 us/op
WorkloadResult  16: 16384 op, 942954600.00 ns, 57.5534 us/op
WorkloadResult  17: 16384 op, 902308500.00 ns, 55.0725 us/op
WorkloadResult  18: 16384 op, 944589200.00 ns, 57.6531 us/op
// GC:  1352 0 0 2831155448 16384
// Threading:  2 0 16384

// AfterAll
// Benchmark Process 10320 has exited with code 0.

Mean = 56.361 us, StdErr = 0.276 us (0.49%), N = 18, StdDev = 1.171 us
Min = 54.691 us, Q1 = 55.253 us, Median = 56.373 us, Q3 = 57.455 us, Max = 58.694 us
IQR = 2.203 us, LowerFence = 51.948 us, UpperFence = 60.760 us
ConfidenceInterval = [55.267 us; 57.455 us] (CI 99.9%), Margin = 1.094 us (1.94% of Mean)
Skewness = 0.18, Kurtosis = 1.82, MValue = 2

// ** Remained 2 (33.3%) benchmark(s) to run. Estimated finish 2024-03-31 16:23 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: StringBenchmarks.ArrayPool: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet d18eb232-e6b0-47ad-8202-9833d80d0465.dll --anonymousPipes 2408 1272 --benchmarkName StringAllocationApp.StringBenchmarks.ArrayPool --job Default --benchmarkId 4 in E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\d18eb232-e6b0-47ad-8202-9833d80d0465\bin\Release\net5.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 274700.00 ns, 274.7000 us/op
WorkloadJitting  1: 1 op, 2146000.00 ns, 2.1460 ms/op

OverheadJitting  2: 16 op, 269000.00 ns, 16.8125 us/op
WorkloadJitting  2: 16 op, 2075000.00 ns, 129.6875 us/op

WorkloadPilot    1: 16 op, 1088200.00 ns, 68.0125 us/op
WorkloadPilot    2: 32 op, 2047100.00 ns, 63.9719 us/op
WorkloadPilot    3: 64 op, 6244300.00 ns, 97.5672 us/op
WorkloadPilot    4: 128 op, 8247600.00 ns, 64.4344 us/op
WorkloadPilot    5: 256 op, 22978100.00 ns, 89.7582 us/op
WorkloadPilot    6: 512 op, 48912900.00 ns, 95.5330 us/op
WorkloadPilot    7: 1024 op, 70342600.00 ns, 68.6939 us/op
WorkloadPilot    8: 2048 op, 137532000.00 ns, 67.1543 us/op
WorkloadPilot    9: 4096 op, 272727300.00 ns, 66.5838 us/op
WorkloadPilot   10: 8192 op, 547538700.00 ns, 66.8382 us/op

OverheadWarmup   1: 8192 op, 24200.00 ns, 2.9541 ns/op
OverheadWarmup   2: 8192 op, 33300.00 ns, 4.0649 ns/op
OverheadWarmup   3: 8192 op, 23300.00 ns, 2.8442 ns/op
OverheadWarmup   4: 8192 op, 23300.00 ns, 2.8442 ns/op
OverheadWarmup   5: 8192 op, 23400.00 ns, 2.8564 ns/op

OverheadActual   1: 8192 op, 39400.00 ns, 4.8096 ns/op
OverheadActual   2: 8192 op, 23600.00 ns, 2.8809 ns/op
OverheadActual   3: 8192 op, 30300.00 ns, 3.6987 ns/op
OverheadActual   4: 8192 op, 34700.00 ns, 4.2358 ns/op
OverheadActual   5: 8192 op, 33700.00 ns, 4.1138 ns/op
OverheadActual   6: 8192 op, 23300.00 ns, 2.8442 ns/op
OverheadActual   7: 8192 op, 23300.00 ns, 2.8442 ns/op
OverheadActual   8: 8192 op, 44400.00 ns, 5.4199 ns/op
OverheadActual   9: 8192 op, 23800.00 ns, 2.9053 ns/op
OverheadActual  10: 8192 op, 33200.00 ns, 4.0527 ns/op
OverheadActual  11: 8192 op, 32700.00 ns, 3.9917 ns/op
OverheadActual  12: 8192 op, 46000.00 ns, 5.6152 ns/op
OverheadActual  13: 8192 op, 33700.00 ns, 4.1138 ns/op
OverheadActual  14: 8192 op, 23500.00 ns, 2.8687 ns/op
OverheadActual  15: 8192 op, 33700.00 ns, 4.1138 ns/op
OverheadActual  16: 8192 op, 33500.00 ns, 4.0894 ns/op
OverheadActual  17: 8192 op, 33500.00 ns, 4.0894 ns/op
OverheadActual  18: 8192 op, 33200.00 ns, 4.0527 ns/op
OverheadActual  19: 8192 op, 32900.00 ns, 4.0161 ns/op
OverheadActual  20: 8192 op, 33800.00 ns, 4.1260 ns/op

WorkloadWarmup   1: 8192 op, 616213200.00 ns, 75.2213 us/op
WorkloadWarmup   2: 8192 op, 551786600.00 ns, 67.3568 us/op
WorkloadWarmup   3: 8192 op, 544000000.00 ns, 66.4062 us/op
WorkloadWarmup   4: 8192 op, 530693800.00 ns, 64.7820 us/op
WorkloadWarmup   5: 8192 op, 545431800.00 ns, 66.5810 us/op
WorkloadWarmup   6: 8192 op, 532223200.00 ns, 64.9687 us/op
WorkloadWarmup   7: 8192 op, 538745900.00 ns, 65.7649 us/op
WorkloadWarmup   8: 8192 op, 545901600.00 ns, 66.6384 us/op
WorkloadWarmup   9: 8192 op, 527487100.00 ns, 64.3905 us/op

// BeforeActualRun
WorkloadActual   1: 8192 op, 546613200.00 ns, 66.7252 us/op
WorkloadActual   2: 8192 op, 561652400.00 ns, 68.5611 us/op
WorkloadActual   3: 8192 op, 542342900.00 ns, 66.2040 us/op
WorkloadActual   4: 8192 op, 552840700.00 ns, 67.4854 us/op
WorkloadActual   5: 8192 op, 540334500.00 ns, 65.9588 us/op
WorkloadActual   6: 8192 op, 530629300.00 ns, 64.7741 us/op
WorkloadActual   7: 8192 op, 581889600.00 ns, 71.0314 us/op
WorkloadActual   8: 8192 op, 542813200.00 ns, 66.2614 us/op
WorkloadActual   9: 8192 op, 555797200.00 ns, 67.8463 us/op
WorkloadActual  10: 8192 op, 542021000.00 ns, 66.1647 us/op
WorkloadActual  11: 8192 op, 547955500.00 ns, 66.8891 us/op
WorkloadActual  12: 8192 op, 596136400.00 ns, 72.7706 us/op
WorkloadActual  13: 8192 op, 550516900.00 ns, 67.2018 us/op
WorkloadActual  14: 8192 op, 551606400.00 ns, 67.3348 us/op
WorkloadActual  15: 8192 op, 557179000.00 ns, 68.0150 us/op

// AfterActualRun
WorkloadResult   1: 8192 op, 546579850.00 ns, 66.7212 us/op
WorkloadResult   2: 8192 op, 561619050.00 ns, 68.5570 us/op
WorkloadResult   3: 8192 op, 542309550.00 ns, 66.1999 us/op
WorkloadResult   4: 8192 op, 552807350.00 ns, 67.4814 us/op
WorkloadResult   5: 8192 op, 540301150.00 ns, 65.9547 us/op
WorkloadResult   6: 8192 op, 530595950.00 ns, 64.7700 us/op
WorkloadResult   7: 8192 op, 542779850.00 ns, 66.2573 us/op
WorkloadResult   8: 8192 op, 555763850.00 ns, 67.8423 us/op
WorkloadResult   9: 8192 op, 541987650.00 ns, 66.1606 us/op
WorkloadResult  10: 8192 op, 547922150.00 ns, 66.8850 us/op
WorkloadResult  11: 8192 op, 550483550.00 ns, 67.1977 us/op
WorkloadResult  12: 8192 op, 551573050.00 ns, 67.3307 us/op
WorkloadResult  13: 8192 op, 557145650.00 ns, 68.0109 us/op
// GC:  1352 0 0 2831157536 8192
// Threading:  2 0 8192

// AfterAll
// Benchmark Process 11368 has exited with code 0.

Mean = 66.875 us, StdErr = 0.282 us (0.42%), N = 13, StdDev = 1.016 us
Min = 64.770 us, Q1 = 66.200 us, Median = 66.885 us, Q3 = 67.481 us, Max = 68.557 us
IQR = 1.281 us, LowerFence = 64.278 us, UpperFence = 69.404 us
ConfidenceInterval = [65.658 us; 68.091 us] (CI 99.9%), Margin = 1.217 us (1.82% of Mean)
Skewness = -0.26, Kurtosis = 2.29, MValue = 2

// ** Remained 1 (16.7%) benchmark(s) to run. Estimated finish 2024-03-31 16:23 (0h 0m from now) **
Setup power plan (GUID: 8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c FriendlyName: High performance)
// **************************
// Benchmark: StringBenchmarks.StringCreate: DefaultJob
// *** Execute ***
// Launch: 1 / 1
// Execute: dotnet d18eb232-e6b0-47ad-8202-9833d80d0465.dll --anonymousPipes 2164 2352 --benchmarkName StringAllocationApp.StringBenchmarks.StringCreate --job Default --benchmarkId 5 in E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\d18eb232-e6b0-47ad-8202-9833d80d0465\bin\Release\net5.0
// BeforeAnythingElse

// Benchmark Process Environment Information:
// BenchmarkDotNet v0.13.12
// Runtime=.NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2
// GC=Concurrent Workstation
// HardwareIntrinsics=AVX2,AES,BMI1,BMI2,FMA,LZCNT,PCLMUL,POPCNT VectorSize=256
// Job: DefaultJob

OverheadJitting  1: 1 op, 273100.00 ns, 273.1000 us/op
WorkloadJitting  1: 1 op, 1844100.00 ns, 1.8441 ms/op

OverheadJitting  2: 16 op, 230300.00 ns, 14.3938 us/op
WorkloadJitting  2: 16 op, 1648200.00 ns, 103.0125 us/op

WorkloadPilot    1: 16 op, 1018900.00 ns, 63.6813 us/op
WorkloadPilot    2: 32 op, 1613900.00 ns, 50.4344 us/op
WorkloadPilot    3: 64 op, 3144000.00 ns, 49.1250 us/op
WorkloadPilot    4: 128 op, 4407100.00 ns, 34.4305 us/op
WorkloadPilot    5: 256 op, 12697400.00 ns, 49.5992 us/op
WorkloadPilot    6: 512 op, 21465600.00 ns, 41.9250 us/op
WorkloadPilot    7: 1024 op, 60414300.00 ns, 58.9983 us/op
WorkloadPilot    8: 2048 op, 78071400.00 ns, 38.1208 us/op
WorkloadPilot    9: 4096 op, 161343600.00 ns, 39.3905 us/op
WorkloadPilot   10: 8192 op, 296198800.00 ns, 36.1571 us/op
WorkloadPilot   11: 16384 op, 603417900.00 ns, 36.8297 us/op

OverheadWarmup   1: 16384 op, 42200.00 ns, 2.5757 ns/op
OverheadWarmup   2: 16384 op, 41800.00 ns, 2.5513 ns/op
OverheadWarmup   3: 16384 op, 41800.00 ns, 2.5513 ns/op
OverheadWarmup   4: 16384 op, 41500.00 ns, 2.5330 ns/op
OverheadWarmup   5: 16384 op, 41900.00 ns, 2.5574 ns/op
OverheadWarmup   6: 16384 op, 41800.00 ns, 2.5513 ns/op

OverheadActual   1: 16384 op, 46200.00 ns, 2.8198 ns/op
OverheadActual   2: 16384 op, 41900.00 ns, 2.5574 ns/op
OverheadActual   3: 16384 op, 42800.00 ns, 2.6123 ns/op
OverheadActual   4: 16384 op, 41800.00 ns, 2.5513 ns/op
OverheadActual   5: 16384 op, 50200.00 ns, 3.0640 ns/op
OverheadActual   6: 16384 op, 46000.00 ns, 2.8076 ns/op
OverheadActual   7: 16384 op, 69600.00 ns, 4.2480 ns/op
OverheadActual   8: 16384 op, 62600.00 ns, 3.8208 ns/op
OverheadActual   9: 16384 op, 67400.00 ns, 4.1138 ns/op
OverheadActual  10: 16384 op, 69200.00 ns, 4.2236 ns/op
OverheadActual  11: 16384 op, 73700.00 ns, 4.4983 ns/op
OverheadActual  12: 16384 op, 45900.00 ns, 2.8015 ns/op
OverheadActual  13: 16384 op, 84500.00 ns, 5.1575 ns/op
OverheadActual  14: 16384 op, 64600.00 ns, 3.9429 ns/op
OverheadActual  15: 16384 op, 47000.00 ns, 2.8687 ns/op
OverheadActual  16: 16384 op, 46300.00 ns, 2.8259 ns/op
OverheadActual  17: 16384 op, 45800.00 ns, 2.7954 ns/op
OverheadActual  18: 16384 op, 65000.00 ns, 3.9673 ns/op
OverheadActual  19: 16384 op, 46800.00 ns, 2.8564 ns/op
OverheadActual  20: 16384 op, 56800.00 ns, 3.4668 ns/op

WorkloadWarmup   1: 16384 op, 664437400.00 ns, 40.5540 us/op
WorkloadWarmup   2: 16384 op, 600489900.00 ns, 36.6510 us/op
WorkloadWarmup   3: 16384 op, 607152900.00 ns, 37.0577 us/op
WorkloadWarmup   4: 16384 op, 620436300.00 ns, 37.8684 us/op
WorkloadWarmup   5: 16384 op, 596148000.00 ns, 36.3860 us/op
WorkloadWarmup   6: 16384 op, 601110300.00 ns, 36.6889 us/op
WorkloadWarmup   7: 16384 op, 614722000.00 ns, 37.5197 us/op
WorkloadWarmup   8: 16384 op, 605368500.00 ns, 36.9488 us/op

// BeforeActualRun
WorkloadActual   1: 16384 op, 605999200.00 ns, 36.9873 us/op
WorkloadActual   2: 16384 op, 602091700.00 ns, 36.7488 us/op
WorkloadActual   3: 16384 op, 608097300.00 ns, 37.1153 us/op
WorkloadActual   4: 16384 op, 604396200.00 ns, 36.8894 us/op
WorkloadActual   5: 16384 op, 626968600.00 ns, 38.2671 us/op
WorkloadActual   6: 16384 op, 606409100.00 ns, 37.0123 us/op
WorkloadActual   7: 16384 op, 600889700.00 ns, 36.6754 us/op
WorkloadActual   8: 16384 op, 616243800.00 ns, 37.6125 us/op
WorkloadActual   9: 16384 op, 602482300.00 ns, 36.7726 us/op
WorkloadActual  10: 16384 op, 596024200.00 ns, 36.3784 us/op
WorkloadActual  11: 16384 op, 622214000.00 ns, 37.9769 us/op
WorkloadActual  12: 16384 op, 633766500.00 ns, 38.6820 us/op
WorkloadActual  13: 16384 op, 603475900.00 ns, 36.8332 us/op
WorkloadActual  14: 16384 op, 616706600.00 ns, 37.6408 us/op
WorkloadActual  15: 16384 op, 639328600.00 ns, 39.0215 us/op
WorkloadActual  16: 16384 op, 624517100.00 ns, 38.1175 us/op
WorkloadActual  17: 16384 op, 590575600.00 ns, 36.0459 us/op
WorkloadActual  18: 16384 op, 600934800.00 ns, 36.6781 us/op
WorkloadActual  19: 16384 op, 608094400.00 ns, 37.1151 us/op

// AfterActualRun
WorkloadResult   1: 16384 op, 605950600.00 ns, 36.9843 us/op
WorkloadResult   2: 16384 op, 602043100.00 ns, 36.7458 us/op
WorkloadResult   3: 16384 op, 608048700.00 ns, 37.1123 us/op
WorkloadResult   4: 16384 op, 604347600.00 ns, 36.8865 us/op
WorkloadResult   5: 16384 op, 626920000.00 ns, 38.2642 us/op
WorkloadResult   6: 16384 op, 606360500.00 ns, 37.0093 us/op
WorkloadResult   7: 16384 op, 600841100.00 ns, 36.6724 us/op
WorkloadResult   8: 16384 op, 616195200.00 ns, 37.6096 us/op
WorkloadResult   9: 16384 op, 602433700.00 ns, 36.7696 us/op
WorkloadResult  10: 16384 op, 595975600.00 ns, 36.3755 us/op
WorkloadResult  11: 16384 op, 622165400.00 ns, 37.9740 us/op
WorkloadResult  12: 16384 op, 633717900.00 ns, 38.6791 us/op
WorkloadResult  13: 16384 op, 603427300.00 ns, 36.8303 us/op
WorkloadResult  14: 16384 op, 616658000.00 ns, 37.6378 us/op
WorkloadResult  15: 16384 op, 639280000.00 ns, 39.0186 us/op
WorkloadResult  16: 16384 op, 624468500.00 ns, 38.1145 us/op
WorkloadResult  17: 16384 op, 590527000.00 ns, 36.0429 us/op
WorkloadResult  18: 16384 op, 600886200.00 ns, 36.6752 us/op
WorkloadResult  19: 16384 op, 608045800.00 ns, 37.1122 us/op
// GC:  1352 0 0 2831155448 16384
// Threading:  2 0 16384

// AfterAll
// Benchmark Process 13452 has exited with code 0.

Mean = 37.290 us, StdErr = 0.184 us (0.49%), N = 19, StdDev = 0.802 us
Min = 36.043 us, Q1 = 36.758 us, Median = 37.009 us, Q3 = 37.806 us, Max = 39.019 us
IQR = 1.048 us, LowerFence = 35.185 us, UpperFence = 39.378 us
ConfidenceInterval = [36.569 us; 38.011 us] (CI 99.9%), Margin = 0.721 us (1.93% of Mean)
Skewness = 0.62, Kurtosis = 2.28, MValue = 2

// ** Remained 0 (0.0%) benchmark(s) to run. Estimated finish 2024-03-31 16:23 (0h 0m from now) **
Successfully reverted power plan (GUID: 381b4222-f694-41f0-9685-ff5bb260df2e FriendlyName: Balanced)
// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts\results\StringAllocationApp.StringBenchmarks-report.csv
  BenchmarkDotNet.Artifacts\results\StringAllocationApp.StringBenchmarks-report-github.md
  BenchmarkDotNet.Artifacts\results\StringAllocationApp.StringBenchmarks-report.html

// * Detailed results *
StringBenchmarks.NoBuilder: DefaultJob
Runtime = .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 542.620 us, StdErr = 2.212 us (0.41%), N = 14, StdDev = 8.275 us
Min = 531.341 us, Q1 = 538.195 us, Median = 540.296 us, Q3 = 546.579 us, Max = 562.057 us
IQR = 8.384 us, LowerFence = 525.618 us, UpperFence = 559.156 us
ConfidenceInterval = [533.285 us; 551.955 us] (CI 99.9%), Margin = 9.335 us (1.72% of Mean)
Skewness = 0.8, Kurtosis = 2.79, MValue = 2
-------------------- Histogram --------------------
[526.834 us ; 542.751 us) | @@@@@@@@@
[542.751 us ; 554.589 us) | @@@@
[554.589 us ; 566.563 us) | @
---------------------------------------------------

StringBenchmarks.Builder: DefaultJob
Runtime = .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 82.284 us, StdErr = 0.350 us (0.43%), N = 15, StdDev = 1.357 us
Min = 80.339 us, Q1 = 81.386 us, Median = 82.217 us, Q3 = 83.294 us, Max = 85.335 us
IQR = 1.908 us, LowerFence = 78.523 us, UpperFence = 86.157 us
ConfidenceInterval = [80.833 us; 83.735 us] (CI 99.9%), Margin = 1.451 us (1.76% of Mean)
Skewness = 0.56, Kurtosis = 2.38, MValue = 2
-------------------- Histogram --------------------
[79.617 us ; 82.327 us) | @@@@@@@@@
[82.327 us ; 84.041 us) | @@@@@
[84.041 us ; 86.057 us) | @
---------------------------------------------------

StringBenchmarks.PooledBuilder: DefaultJob
Runtime = .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 67.795 us, StdErr = 0.348 us (0.51%), N = 20, StdDev = 1.558 us
Min = 65.764 us, Q1 = 66.632 us, Median = 67.653 us, Q3 = 68.610 us, Max = 70.423 us
IQR = 1.978 us, LowerFence = 63.666 us, UpperFence = 71.577 us
ConfidenceInterval = [66.442 us; 69.148 us] (CI 99.9%), Margin = 1.353 us (2.00% of Mean)
Skewness = 0.38, Kurtosis = 1.78, MValue = 2
-------------------- Histogram --------------------
[65.652 us ; 67.159 us) | @@@@@@@@@
[67.159 us ; 68.693 us) | @@@@@@
[68.693 us ; 70.498 us) | @@@@@
---------------------------------------------------

StringBenchmarks.ArrayPool: DefaultJob
Runtime = .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 66.875 us, StdErr = 0.282 us (0.42%), N = 13, StdDev = 1.016 us
Min = 64.770 us, Q1 = 66.200 us, Median = 66.885 us, Q3 = 67.481 us, Max = 68.557 us
IQR = 1.281 us, LowerFence = 64.278 us, UpperFence = 69.404 us
ConfidenceInterval = [65.658 us; 68.091 us] (CI 99.9%), Margin = 1.217 us (1.82% of Mean)
Skewness = -0.26, Kurtosis = 2.29, MValue = 2
-------------------- Histogram --------------------
[64.203 us ; 65.756 us) | @
[65.756 us ; 69.124 us) | @@@@@@@@@@@@
---------------------------------------------------

StringBenchmarks.StackAllocated: DefaultJob
Runtime = .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 56.361 us, StdErr = 0.276 us (0.49%), N = 18, StdDev = 1.171 us
Min = 54.691 us, Q1 = 55.253 us, Median = 56.373 us, Q3 = 57.455 us, Max = 58.694 us
IQR = 2.203 us, LowerFence = 51.948 us, UpperFence = 60.760 us
ConfidenceInterval = [55.267 us; 57.455 us] (CI 99.9%), Margin = 1.094 us (1.94% of Mean)
Skewness = 0.18, Kurtosis = 1.82, MValue = 2
-------------------- Histogram --------------------
[54.295 us ; 55.680 us) | @@@@@
[55.680 us ; 56.852 us) | @@@@@@@
[56.852 us ; 58.037 us) | @@@@@
[58.037 us ; 59.280 us) | @
---------------------------------------------------

StringBenchmarks.StringCreate: DefaultJob
Runtime = .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2; GC = Concurrent Workstation
Mean = 37.290 us, StdErr = 0.184 us (0.49%), N = 19, StdDev = 0.802 us
Min = 36.043 us, Q1 = 36.758 us, Median = 37.009 us, Q3 = 37.806 us, Max = 39.019 us
IQR = 1.048 us, LowerFence = 35.185 us, UpperFence = 39.378 us
ConfidenceInterval = [36.569 us; 38.011 us] (CI 99.9%), Margin = 0.721 us (1.93% of Mean)
Skewness = 0.62, Kurtosis = 2.28, MValue = 2
-------------------- Histogram --------------------
[35.649 us ; 37.138 us) | @@@@@@@@@@@@
[37.138 us ; 38.331 us) | @@@@@
[38.331 us ; 39.243 us) | @@
---------------------------------------------------

// * Summary *

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22621.3296/22H2/2022Update/SunValley2)
Intel Core i7-4510U CPU 2.00GHz (Haswell), 1 CPU, 4 logical and 2 physical cores
.NET SDK 5.0.102
  [Host]     : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT AVX2


| Method         | Mean      | Error    | StdDev   | Gen0      | Allocated |
|--------------- |----------:|---------:|---------:|----------:|----------:|
| NoBuilder      | 542.62 us | 9.335 us | 8.275 us | 2128.9063 |   4350 KB |
| Builder        |  82.28 us | 1.451 us | 1.357 us |  183.7158 | 375.78 KB |
| PooledBuilder  |  67.79 us | 1.353 us | 1.558 us |   85.6934 | 175.28 KB |
| ArrayPool      |  66.87 us | 1.217 us | 1.016 us |  165.0391 |  337.5 KB |
| StackAllocated |  56.36 us | 1.094 us | 1.171 us |   82.5195 | 168.75 KB |
| StringCreate   |  37.29 us | 0.721 us | 0.802 us |   82.5195 | 168.75 KB |

// * Warnings *
Environment
  Summary -> Benchmark was executed with attached debugger

// * Hints *
Outliers
  StringBenchmarks.NoBuilder: Default -> 1 outlier  was  removed (574.81 us)
  StringBenchmarks.ArrayPool: Default -> 2 outliers were removed (71.03 us, 72.77 us)

// * Legends *
  Mean      : Arithmetic mean of all measurements
  Error     : Half of 99.9% confidence interval
  StdDev    : Standard deviation of all measurements
  Gen0      : GC Generation 0 collects per 1000 operations
  Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  1 us      : 1 Microsecond (0.000001 sec)

// * Diagnostic Output - MemoryDiagnoser *


// ***** BenchmarkRunner: End *****
Run time: 00:01:51 (111.89 sec), executed benchmarks: 6

Global total time: 00:02:03 (123.77 sec), executed benchmarks: 6
// * Artifacts cleanup *
Artifacts cleanup is finished

E:\workspace\StringExercises\StringAllocationApp\bin\Release\net5.0\StringAllocationApp.exe (process 13464) exited withcode 0.
To automatically close the console when debugging stops, enable Tools->Options->Debugging->Automatically close the console when debugging stops.
Press any key to close this window . . .

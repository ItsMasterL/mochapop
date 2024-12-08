; ModuleID = 'compressed_assemblies.arm64-v8a.ll'
source_filename = "compressed_assemblies.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android21"

%struct.CompressedAssemblies = type {
	i32, ; uint32_t count
	ptr ; CompressedAssemblyDescriptor descriptors
}

%struct.CompressedAssemblyDescriptor = type {
	i32, ; uint32_t uncompressed_file_size
	i8, ; bool loaded
	ptr ; uint8_t data
}

@compressed_assemblies = dso_local local_unnamed_addr global %struct.CompressedAssemblies {
	i32 64, ; uint32_t count (0x40)
	ptr @compressed_assembly_descriptors; CompressedAssemblyDescriptor* descriptors
}, align 8

@compressed_assembly_descriptors = internal dso_local global [64 x %struct.CompressedAssemblyDescriptor] [
	%struct.CompressedAssemblyDescriptor {
		i32 10240, ; uint32_t uncompressed_file_size (0x2800)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_0; uint8_t* data (0x0)
	}, ; 0
	%struct.CompressedAssemblyDescriptor {
		i32 147456, ; uint32_t uncompressed_file_size (0x24000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_1; uint8_t* data (0x0)
	}, ; 1
	%struct.CompressedAssemblyDescriptor {
		i32 18976, ; uint32_t uncompressed_file_size (0x4a20)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_2; uint8_t* data (0x0)
	}, ; 2
	%struct.CompressedAssemblyDescriptor {
		i32 602624, ; uint32_t uncompressed_file_size (0x93200)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_3; uint8_t* data (0x0)
	}, ; 3
	%struct.CompressedAssemblyDescriptor {
		i32 381952, ; uint32_t uncompressed_file_size (0x5d400)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_4; uint8_t* data (0x0)
	}, ; 4
	%struct.CompressedAssemblyDescriptor {
		i32 983040, ; uint32_t uncompressed_file_size (0xf0000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_5; uint8_t* data (0x0)
	}, ; 5
	%struct.CompressedAssemblyDescriptor {
		i32 13312, ; uint32_t uncompressed_file_size (0x3400)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_6; uint8_t* data (0x0)
	}, ; 6
	%struct.CompressedAssemblyDescriptor {
		i32 10240, ; uint32_t uncompressed_file_size (0x2800)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_7; uint8_t* data (0x0)
	}, ; 7
	%struct.CompressedAssemblyDescriptor {
		i32 7168, ; uint32_t uncompressed_file_size (0x1c00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_8; uint8_t* data (0x0)
	}, ; 8
	%struct.CompressedAssemblyDescriptor {
		i32 77824, ; uint32_t uncompressed_file_size (0x13000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_9; uint8_t* data (0x0)
	}, ; 9
	%struct.CompressedAssemblyDescriptor {
		i32 4096, ; uint32_t uncompressed_file_size (0x1000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_10; uint8_t* data (0x0)
	}, ; 10
	%struct.CompressedAssemblyDescriptor {
		i32 10752, ; uint32_t uncompressed_file_size (0x2a00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_11; uint8_t* data (0x0)
	}, ; 11
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uint32_t uncompressed_file_size (0x1200)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_12; uint8_t* data (0x0)
	}, ; 12
	%struct.CompressedAssemblyDescriptor {
		i32 14848, ; uint32_t uncompressed_file_size (0x3a00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_13; uint8_t* data (0x0)
	}, ; 13
	%struct.CompressedAssemblyDescriptor {
		i32 9728, ; uint32_t uncompressed_file_size (0x2600)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_14; uint8_t* data (0x0)
	}, ; 14
	%struct.CompressedAssemblyDescriptor {
		i32 4096, ; uint32_t uncompressed_file_size (0x1000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_15; uint8_t* data (0x0)
	}, ; 15
	%struct.CompressedAssemblyDescriptor {
		i32 19456, ; uint32_t uncompressed_file_size (0x4c00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_16; uint8_t* data (0x0)
	}, ; 16
	%struct.CompressedAssemblyDescriptor {
		i32 27648, ; uint32_t uncompressed_file_size (0x6c00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_17; uint8_t* data (0x0)
	}, ; 17
	%struct.CompressedAssemblyDescriptor {
		i32 343552, ; uint32_t uncompressed_file_size (0x53e00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_18; uint8_t* data (0x0)
	}, ; 18
	%struct.CompressedAssemblyDescriptor {
		i32 23552, ; uint32_t uncompressed_file_size (0x5c00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_19; uint8_t* data (0x0)
	}, ; 19
	%struct.CompressedAssemblyDescriptor {
		i32 12800, ; uint32_t uncompressed_file_size (0x3200)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_20; uint8_t* data (0x0)
	}, ; 20
	%struct.CompressedAssemblyDescriptor {
		i32 118784, ; uint32_t uncompressed_file_size (0x1d000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_21; uint8_t* data (0x0)
	}, ; 21
	%struct.CompressedAssemblyDescriptor {
		i32 33792, ; uint32_t uncompressed_file_size (0x8400)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_22; uint8_t* data (0x0)
	}, ; 22
	%struct.CompressedAssemblyDescriptor {
		i32 6144, ; uint32_t uncompressed_file_size (0x1800)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_23; uint8_t* data (0x0)
	}, ; 23
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uint32_t uncompressed_file_size (0x1200)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_24; uint8_t* data (0x0)
	}, ; 24
	%struct.CompressedAssemblyDescriptor {
		i32 5120, ; uint32_t uncompressed_file_size (0x1400)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_25; uint8_t* data (0x0)
	}, ; 25
	%struct.CompressedAssemblyDescriptor {
		i32 66048, ; uint32_t uncompressed_file_size (0x10200)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_26; uint8_t* data (0x0)
	}, ; 26
	%struct.CompressedAssemblyDescriptor {
		i32 497664, ; uint32_t uncompressed_file_size (0x79800)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_27; uint8_t* data (0x0)
	}, ; 27
	%struct.CompressedAssemblyDescriptor {
		i32 8192, ; uint32_t uncompressed_file_size (0x2000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_28; uint8_t* data (0x0)
	}, ; 28
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uint32_t uncompressed_file_size (0x1200)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_29; uint8_t* data (0x0)
	}, ; 29
	%struct.CompressedAssemblyDescriptor {
		i32 10752, ; uint32_t uncompressed_file_size (0x2a00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_30; uint8_t* data (0x0)
	}, ; 30
	%struct.CompressedAssemblyDescriptor {
		i32 12800, ; uint32_t uncompressed_file_size (0x3200)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_31; uint8_t* data (0x0)
	}, ; 31
	%struct.CompressedAssemblyDescriptor {
		i32 4096, ; uint32_t uncompressed_file_size (0x1000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_32; uint8_t* data (0x0)
	}, ; 32
	%struct.CompressedAssemblyDescriptor {
		i32 136704, ; uint32_t uncompressed_file_size (0x21600)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_33; uint8_t* data (0x0)
	}, ; 33
	%struct.CompressedAssemblyDescriptor {
		i32 4096, ; uint32_t uncompressed_file_size (0x1000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_34; uint8_t* data (0x0)
	}, ; 34
	%struct.CompressedAssemblyDescriptor {
		i32 11264, ; uint32_t uncompressed_file_size (0x2c00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_35; uint8_t* data (0x0)
	}, ; 35
	%struct.CompressedAssemblyDescriptor {
		i32 4608, ; uint32_t uncompressed_file_size (0x1200)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_36; uint8_t* data (0x0)
	}, ; 36
	%struct.CompressedAssemblyDescriptor {
		i32 4096, ; uint32_t uncompressed_file_size (0x1000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_37; uint8_t* data (0x0)
	}, ; 37
	%struct.CompressedAssemblyDescriptor {
		i32 4096, ; uint32_t uncompressed_file_size (0x1000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_38; uint8_t* data (0x0)
	}, ; 38
	%struct.CompressedAssemblyDescriptor {
		i32 2560, ; uint32_t uncompressed_file_size (0xa00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_39; uint8_t* data (0x0)
	}, ; 39
	%struct.CompressedAssemblyDescriptor {
		i32 26112, ; uint32_t uncompressed_file_size (0x6600)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_40; uint8_t* data (0x0)
	}, ; 40
	%struct.CompressedAssemblyDescriptor {
		i32 15872, ; uint32_t uncompressed_file_size (0x3e00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_41; uint8_t* data (0x0)
	}, ; 41
	%struct.CompressedAssemblyDescriptor {
		i32 1783296, ; uint32_t uncompressed_file_size (0x1b3600)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_42; uint8_t* data (0x0)
	}, ; 42
	%struct.CompressedAssemblyDescriptor {
		i32 31232, ; uint32_t uncompressed_file_size (0x7a00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_43; uint8_t* data (0x0)
	}, ; 43
	%struct.CompressedAssemblyDescriptor {
		i32 341504, ; uint32_t uncompressed_file_size (0x53600)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_44; uint8_t* data (0x0)
	}, ; 44
	%struct.CompressedAssemblyDescriptor {
		i32 20480, ; uint32_t uncompressed_file_size (0x5000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_45; uint8_t* data (0x0)
	}, ; 45
	%struct.CompressedAssemblyDescriptor {
		i32 25600, ; uint32_t uncompressed_file_size (0x6400)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_46; uint8_t* data (0x0)
	}, ; 46
	%struct.CompressedAssemblyDescriptor {
		i32 15360, ; uint32_t uncompressed_file_size (0x3c00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_47; uint8_t* data (0x0)
	}, ; 47
	%struct.CompressedAssemblyDescriptor {
		i32 1767936, ; uint32_t uncompressed_file_size (0x1afa00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_48; uint8_t* data (0x0)
	}, ; 48
	%struct.CompressedAssemblyDescriptor {
		i32 28160, ; uint32_t uncompressed_file_size (0x6e00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_49; uint8_t* data (0x0)
	}, ; 49
	%struct.CompressedAssemblyDescriptor {
		i32 342016, ; uint32_t uncompressed_file_size (0x53800)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_50; uint8_t* data (0x0)
	}, ; 50
	%struct.CompressedAssemblyDescriptor {
		i32 20480, ; uint32_t uncompressed_file_size (0x5000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_51; uint8_t* data (0x0)
	}, ; 51
	%struct.CompressedAssemblyDescriptor {
		i32 25600, ; uint32_t uncompressed_file_size (0x6400)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_52; uint8_t* data (0x0)
	}, ; 52
	%struct.CompressedAssemblyDescriptor {
		i32 15360, ; uint32_t uncompressed_file_size (0x3c00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_53; uint8_t* data (0x0)
	}, ; 53
	%struct.CompressedAssemblyDescriptor {
		i32 1767424, ; uint32_t uncompressed_file_size (0x1af800)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_54; uint8_t* data (0x0)
	}, ; 54
	%struct.CompressedAssemblyDescriptor {
		i32 28160, ; uint32_t uncompressed_file_size (0x6e00)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_55; uint8_t* data (0x0)
	}, ; 55
	%struct.CompressedAssemblyDescriptor {
		i32 342016, ; uint32_t uncompressed_file_size (0x53800)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_56; uint8_t* data (0x0)
	}, ; 56
	%struct.CompressedAssemblyDescriptor {
		i32 20480, ; uint32_t uncompressed_file_size (0x5000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_57; uint8_t* data (0x0)
	}, ; 57
	%struct.CompressedAssemblyDescriptor {
		i32 26112, ; uint32_t uncompressed_file_size (0x6600)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_58; uint8_t* data (0x0)
	}, ; 58
	%struct.CompressedAssemblyDescriptor {
		i32 16384, ; uint32_t uncompressed_file_size (0x4000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_59; uint8_t* data (0x0)
	}, ; 59
	%struct.CompressedAssemblyDescriptor {
		i32 1828864, ; uint32_t uncompressed_file_size (0x1be800)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_60; uint8_t* data (0x0)
	}, ; 60
	%struct.CompressedAssemblyDescriptor {
		i32 30208, ; uint32_t uncompressed_file_size (0x7600)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_61; uint8_t* data (0x0)
	}, ; 61
	%struct.CompressedAssemblyDescriptor {
		i32 341504, ; uint32_t uncompressed_file_size (0x53600)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_62; uint8_t* data (0x0)
	}, ; 62
	%struct.CompressedAssemblyDescriptor {
		i32 20480, ; uint32_t uncompressed_file_size (0x5000)
		i8 0, ; bool loaded
		ptr @__compressedAssemblyData_63; uint8_t* data (0x0)
	} ; 63
], align 8

@__compressedAssemblyData_0 = internal dso_local global [10240 x i8] zeroinitializer, align 1
@__compressedAssemblyData_1 = internal dso_local global [147456 x i8] zeroinitializer, align 1
@__compressedAssemblyData_2 = internal dso_local global [18976 x i8] zeroinitializer, align 1
@__compressedAssemblyData_3 = internal dso_local global [602624 x i8] zeroinitializer, align 1
@__compressedAssemblyData_4 = internal dso_local global [381952 x i8] zeroinitializer, align 1
@__compressedAssemblyData_5 = internal dso_local global [983040 x i8] zeroinitializer, align 1
@__compressedAssemblyData_6 = internal dso_local global [13312 x i8] zeroinitializer, align 1
@__compressedAssemblyData_7 = internal dso_local global [10240 x i8] zeroinitializer, align 1
@__compressedAssemblyData_8 = internal dso_local global [7168 x i8] zeroinitializer, align 1
@__compressedAssemblyData_9 = internal dso_local global [77824 x i8] zeroinitializer, align 1
@__compressedAssemblyData_10 = internal dso_local global [4096 x i8] zeroinitializer, align 1
@__compressedAssemblyData_11 = internal dso_local global [10752 x i8] zeroinitializer, align 1
@__compressedAssemblyData_12 = internal dso_local global [4608 x i8] zeroinitializer, align 1
@__compressedAssemblyData_13 = internal dso_local global [14848 x i8] zeroinitializer, align 1
@__compressedAssemblyData_14 = internal dso_local global [9728 x i8] zeroinitializer, align 1
@__compressedAssemblyData_15 = internal dso_local global [4096 x i8] zeroinitializer, align 1
@__compressedAssemblyData_16 = internal dso_local global [19456 x i8] zeroinitializer, align 1
@__compressedAssemblyData_17 = internal dso_local global [27648 x i8] zeroinitializer, align 1
@__compressedAssemblyData_18 = internal dso_local global [343552 x i8] zeroinitializer, align 1
@__compressedAssemblyData_19 = internal dso_local global [23552 x i8] zeroinitializer, align 1
@__compressedAssemblyData_20 = internal dso_local global [12800 x i8] zeroinitializer, align 1
@__compressedAssemblyData_21 = internal dso_local global [118784 x i8] zeroinitializer, align 1
@__compressedAssemblyData_22 = internal dso_local global [33792 x i8] zeroinitializer, align 1
@__compressedAssemblyData_23 = internal dso_local global [6144 x i8] zeroinitializer, align 1
@__compressedAssemblyData_24 = internal dso_local global [4608 x i8] zeroinitializer, align 1
@__compressedAssemblyData_25 = internal dso_local global [5120 x i8] zeroinitializer, align 1
@__compressedAssemblyData_26 = internal dso_local global [66048 x i8] zeroinitializer, align 1
@__compressedAssemblyData_27 = internal dso_local global [497664 x i8] zeroinitializer, align 1
@__compressedAssemblyData_28 = internal dso_local global [8192 x i8] zeroinitializer, align 1
@__compressedAssemblyData_29 = internal dso_local global [4608 x i8] zeroinitializer, align 1
@__compressedAssemblyData_30 = internal dso_local global [10752 x i8] zeroinitializer, align 1
@__compressedAssemblyData_31 = internal dso_local global [12800 x i8] zeroinitializer, align 1
@__compressedAssemblyData_32 = internal dso_local global [4096 x i8] zeroinitializer, align 1
@__compressedAssemblyData_33 = internal dso_local global [136704 x i8] zeroinitializer, align 1
@__compressedAssemblyData_34 = internal dso_local global [4096 x i8] zeroinitializer, align 1
@__compressedAssemblyData_35 = internal dso_local global [11264 x i8] zeroinitializer, align 1
@__compressedAssemblyData_36 = internal dso_local global [4608 x i8] zeroinitializer, align 1
@__compressedAssemblyData_37 = internal dso_local global [4096 x i8] zeroinitializer, align 1
@__compressedAssemblyData_38 = internal dso_local global [4096 x i8] zeroinitializer, align 1
@__compressedAssemblyData_39 = internal dso_local global [2560 x i8] zeroinitializer, align 1
@__compressedAssemblyData_40 = internal dso_local global [26112 x i8] zeroinitializer, align 1
@__compressedAssemblyData_41 = internal dso_local global [15872 x i8] zeroinitializer, align 1
@__compressedAssemblyData_42 = internal dso_local global [1783296 x i8] zeroinitializer, align 1
@__compressedAssemblyData_43 = internal dso_local global [31232 x i8] zeroinitializer, align 1
@__compressedAssemblyData_44 = internal dso_local global [341504 x i8] zeroinitializer, align 1
@__compressedAssemblyData_45 = internal dso_local global [20480 x i8] zeroinitializer, align 1
@__compressedAssemblyData_46 = internal dso_local global [25600 x i8] zeroinitializer, align 1
@__compressedAssemblyData_47 = internal dso_local global [15360 x i8] zeroinitializer, align 1
@__compressedAssemblyData_48 = internal dso_local global [1767936 x i8] zeroinitializer, align 1
@__compressedAssemblyData_49 = internal dso_local global [28160 x i8] zeroinitializer, align 1
@__compressedAssemblyData_50 = internal dso_local global [342016 x i8] zeroinitializer, align 1
@__compressedAssemblyData_51 = internal dso_local global [20480 x i8] zeroinitializer, align 1
@__compressedAssemblyData_52 = internal dso_local global [25600 x i8] zeroinitializer, align 1
@__compressedAssemblyData_53 = internal dso_local global [15360 x i8] zeroinitializer, align 1
@__compressedAssemblyData_54 = internal dso_local global [1767424 x i8] zeroinitializer, align 1
@__compressedAssemblyData_55 = internal dso_local global [28160 x i8] zeroinitializer, align 1
@__compressedAssemblyData_56 = internal dso_local global [342016 x i8] zeroinitializer, align 1
@__compressedAssemblyData_57 = internal dso_local global [20480 x i8] zeroinitializer, align 1
@__compressedAssemblyData_58 = internal dso_local global [26112 x i8] zeroinitializer, align 1
@__compressedAssemblyData_59 = internal dso_local global [16384 x i8] zeroinitializer, align 1
@__compressedAssemblyData_60 = internal dso_local global [1828864 x i8] zeroinitializer, align 1
@__compressedAssemblyData_61 = internal dso_local global [30208 x i8] zeroinitializer, align 1
@__compressedAssemblyData_62 = internal dso_local global [341504 x i8] zeroinitializer, align 1
@__compressedAssemblyData_63 = internal dso_local global [20480 x i8] zeroinitializer, align 1

; Metadata
!llvm.module.flags = !{!0, !1, !7, !8, !9, !10}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!llvm.ident = !{!2}
!2 = !{!"Xamarin.Android remotes/origin/release/8.0.1xx @ af27162bee43b7fecdca59b4f67aa8c175cbc875"}
!3 = !{!4, !4, i64 0}
!4 = !{!"any pointer", !5, i64 0}
!5 = !{!"omnipotent char", !6, i64 0}
!6 = !{!"Simple C++ TBAA"}
!7 = !{i32 1, !"branch-target-enforcement", i32 0}
!8 = !{i32 1, !"sign-return-address", i32 0}
!9 = !{i32 1, !"sign-return-address-all", i32 0}
!10 = !{i32 1, !"sign-return-address-with-bkey", i32 0}

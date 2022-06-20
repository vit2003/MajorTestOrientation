﻿// <auto-generated />
using System;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Entities.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.CollegeRefMajor", b =>
                {
                    b.Property<int>("MajorId")
                        .HasColumnName("MajorID")
                        .HasColumnType("int");

                    b.Property<int>("CollegeId")
                        .HasColumnName("CollegeID")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.HasKey("MajorId", "CollegeId")
                        .HasName("PK__College___572CB6E089C2CACB");

                    b.HasIndex("CollegeId");

                    b.ToTable("College_Ref_Major");
                });

            modelBuilder.Entity("Entities.Models.Colleges", b =>
                {
                    b.Property<int>("CollegeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("CollegeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CollegeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("CollegeTypeId")
                        .HasColumnName("CollegeTypeID")
                        .HasColumnType("int");

                    b.Property<float>("FromGpa")
                        .HasColumnName("FromGPA")
                        .HasColumnType("real");

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<float>("ToGpa")
                        .HasColumnName("ToGPA")
                        .HasColumnType("real");

                    b.HasKey("CollegeId")
                        .HasName("PK__Colleges__29409519E55EE24B");

                    b.ToTable("Colleges");
                });

            modelBuilder.Entity("Entities.Models.LearningPathDetails", b =>
                {
                    b.Property<int>("LearningPathDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LearningPathDetailID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("LearningPathDetailContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("LearningPathId")
                        .HasColumnName("LearningPathID")
                        .HasColumnType("int");

                    b.Property<int>("OrderIndex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("((1))");

                    b.HasKey("LearningPathDetailId")
                        .HasName("PK__Learning__40D9D999F16AA74B");

                    b.HasIndex("LearningPathId");

                    b.ToTable("LearningPathDetails");
                });

            modelBuilder.Entity("Entities.Models.LearningPaths", b =>
                {
                    b.Property<int>("LearningPathId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("LearningPathID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<int>("MajorId")
                        .HasColumnName("MajorID")
                        .HasColumnType("int");

                    b.HasKey("LearningPathId")
                        .HasName("PK__Learning__20DCAEA1FA5B114D");

                    b.HasIndex("MajorId");

                    b.ToTable("Learning_Paths");
                });

            modelBuilder.Entity("Entities.Models.MajorRefPersonality", b =>
                {
                    b.Property<int>("PersonalityGroupId")
                        .HasColumnName("PersonalityGroupID")
                        .HasColumnType("int");

                    b.Property<int>("MajorId")
                        .HasColumnName("MajorID")
                        .HasColumnType("int");

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.HasKey("PersonalityGroupId", "MajorId")
                        .HasName("PK__Major_Re__E28E6459D09867C3");

                    b.HasIndex("MajorId");

                    b.ToTable("Major_Ref_Personality");
                });

            modelBuilder.Entity("Entities.Models.Majors", b =>
                {
                    b.Property<int>("MajorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("MajorID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("MajorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("MajorId")
                        .HasName("PK__Majors__D5B8BFB1FFCDC09F");

                    b.ToTable("Majors");
                });

            modelBuilder.Entity("Entities.Models.SecurityCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("SECURITY_CODE");
                });

            modelBuilder.Entity("Entities.Models.SysUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("UserID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminIdUpdate")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("date");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool?>("Gender")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<float?>("Gpa10")
                        .HasColumnName("GPA10")
                        .HasColumnType("real");

                    b.Property<float?>("Gpa11")
                        .HasColumnName("GPA11")
                        .HasColumnType("real");

                    b.Property<float?>("Gpa12")
                        .HasColumnName("GPA12")
                        .HasColumnType("real");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("ImagePath")
                        .HasColumnType("varchar(400)")
                        .HasMaxLength(400)
                        .IsUnicode(false);

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<bool?>("IsLocked")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("RoleId")
                        .HasColumnName("RoleID")
                        .HasColumnType("int");

                    b.Property<int?>("UpdateAdminUserId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("date");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.HasKey("UserId")
                        .HasName("PK_SYSTEM_USER");

                    b.HasIndex("RoleId");

                    b.HasIndex("UpdateAdminUserId");

                    b.ToTable("Sys_User");
                });

            modelBuilder.Entity("Entities.Models.SysUserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("RoleID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("RoleId")
                        .HasName("PK_USER_POSITION");

                    b.ToTable("Sys_User_Role");
                });

            modelBuilder.Entity("Entities.Models.TestAnswers", b =>
                {
                    b.Property<int>("AnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("AnswerID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AnswerContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<int>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<int>("PersonalityGroupId")
                        .HasColumnName("PersonalityGroupID")
                        .HasColumnType("int");

                    b.Property<int>("Point")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnName("QuestionID")
                        .HasColumnType("int");

                    b.HasKey("AnswerId")
                        .HasName("PK__Test_Ans__D4825024C8BB5FCE");

                    b.HasIndex("PersonalityGroupId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Test_Answers");
                });

            modelBuilder.Entity("Entities.Models.TestDeclarations", b =>
                {
                    b.Property<int>("TestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TestID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("CreatedUser")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool?>("IsActive")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("TestDescrip")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TestTypeId")
                        .HasColumnName("TestTypeID")
                        .HasColumnType("int");

                    b.HasKey("TestId")
                        .HasName("PK__Test_Dec__8CC33100AFED4550");

                    b.HasIndex("TestTypeId");

                    b.ToTable("Test_Declarations");
                });

            modelBuilder.Entity("Entities.Models.TestPersonalityGroups", b =>
                {
                    b.Property<int>("PersonalityGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("PersonalityGroupID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("PersonalityGroupName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("TestTypeId")
                        .HasColumnName("TestTypeID")
                        .HasColumnType("int");

                    b.HasKey("PersonalityGroupId")
                        .HasName("PK__Test_Per__EFD5EFA226ABA06D");

                    b.HasIndex("TestTypeId");

                    b.ToTable("Test_Personality_Groups");
                });

            modelBuilder.Entity("Entities.Models.TestQuestions", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("QuestionID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<int>("OrderIndex")
                        .HasColumnType("int");

                    b.Property<string>("QuestionContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("TestId")
                        .HasColumnName("TestID")
                        .HasColumnType("int");

                    b.HasKey("QuestionId")
                        .HasName("PK__Test_Que__0DC06F8C223898C0");

                    b.HasIndex("TestId");

                    b.ToTable("Test_Questions");
                });

            modelBuilder.Entity("Entities.Models.TestResults", b =>
                {
                    b.Property<int>("TestResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TestResultID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnswerId")
                        .HasColumnName("AnswerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("date");

                    b.Property<bool?>("IsLast")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('1')");

                    b.Property<int>("QuestionId")
                        .HasColumnName("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("TestId")
                        .HasColumnName("TestID")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.HasKey("TestResultId")
                        .HasName("PK__Test_Res__E2463A674228CD84");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("TestId");

                    b.HasIndex("UserId");

                    b.ToTable("Test_Results");
                });

            modelBuilder.Entity("Entities.Models.TestTypes", b =>
                {
                    b.Property<int>("TestTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("TestTypeID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool?>("IsDeleted")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValueSql("('0')");

                    b.Property<string>("TestTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("TestTypeId")
                        .HasName("PK__Test_Typ__9BB876465EDCF709");

                    b.ToTable("Test_Types");
                });

            modelBuilder.Entity("Entities.Models.UserLearningPath", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.Property<int>("LearningPathId")
                        .HasColumnName("LearningPathID")
                        .HasColumnType("int");

                    b.HasKey("UserId", "LearningPathId")
                        .HasName("PK__User_Lea__15850646891BC882");

                    b.HasIndex("LearningPathId");

                    b.ToTable("User_LearningPath");
                });

            modelBuilder.Entity("Entities.Models.VcGuidance", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnName("UserID")
                        .HasColumnType("int");

                    b.Property<int>("CollegeId")
                        .HasColumnName("CollegeID")
                        .HasColumnType("int");

                    b.Property<int>("MajorId")
                        .HasColumnName("MajorID")
                        .HasColumnType("int");

                    b.HasKey("UserId", "CollegeId", "MajorId")
                        .HasName("PK__VC_Guida__25C97D42CD3C4906");

                    b.HasIndex("CollegeId");

                    b.HasIndex("MajorId");

                    b.ToTable("VC_Guidance");
                });

            modelBuilder.Entity("Entities.Models.CollegeRefMajor", b =>
                {
                    b.HasOne("Entities.Models.Colleges", "College")
                        .WithMany("CollegeRefMajor")
                        .HasForeignKey("CollegeId")
                        .HasConstraintName("FKCollege_Re287083")
                        .IsRequired();

                    b.HasOne("Entities.Models.Majors", "Major")
                        .WithMany("CollegeRefMajor")
                        .HasForeignKey("MajorId")
                        .HasConstraintName("FKCollege_Re494710")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.LearningPathDetails", b =>
                {
                    b.HasOne("Entities.Models.LearningPaths", "LearningPath")
                        .WithMany("LearningPathDetails")
                        .HasForeignKey("LearningPathId")
                        .HasConstraintName("FKLearningPa175463")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.LearningPaths", b =>
                {
                    b.HasOne("Entities.Models.Majors", "Major")
                        .WithMany("LearningPaths")
                        .HasForeignKey("MajorId")
                        .HasConstraintName("FKLearning_P92098")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.MajorRefPersonality", b =>
                {
                    b.HasOne("Entities.Models.Majors", "Major")
                        .WithMany("MajorRefPersonality")
                        .HasForeignKey("MajorId")
                        .HasConstraintName("FKMajor_Ref_224122")
                        .IsRequired();

                    b.HasOne("Entities.Models.TestPersonalityGroups", "PersonalityGroup")
                        .WithMany("MajorRefPersonality")
                        .HasForeignKey("PersonalityGroupId")
                        .HasConstraintName("FKMajor_Ref_93769")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.SecurityCode", b =>
                {
                    b.HasOne("Entities.Models.SysUser", "user")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.SysUser", b =>
                {
                    b.HasOne("Entities.Models.SysUserRole", "Role")
                        .WithMany("SysUser")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FKSys_User142060")
                        .IsRequired();

                    b.HasOne("Entities.Models.SysUser", "UpdateAdmin")
                        .WithMany()
                        .HasForeignKey("UpdateAdminUserId");
                });

            modelBuilder.Entity("Entities.Models.TestAnswers", b =>
                {
                    b.HasOne("Entities.Models.TestPersonalityGroups", "PersonalityGroup")
                        .WithMany("TestAnswers")
                        .HasForeignKey("PersonalityGroupId")
                        .HasConstraintName("FKTest_Answe19835")
                        .IsRequired();

                    b.HasOne("Entities.Models.TestQuestions", "Question")
                        .WithMany("TestAnswers")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FKTest_Answe601746")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.TestDeclarations", b =>
                {
                    b.HasOne("Entities.Models.TestTypes", "TestType")
                        .WithMany("TestDeclarations")
                        .HasForeignKey("TestTypeId")
                        .HasConstraintName("FKTest_Decla953794")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.TestPersonalityGroups", b =>
                {
                    b.HasOne("Entities.Models.TestTypes", "TestType")
                        .WithMany("TestPersonalityGroups")
                        .HasForeignKey("TestTypeId")
                        .HasConstraintName("FKTest_Perso404711")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.TestQuestions", b =>
                {
                    b.HasOne("Entities.Models.TestDeclarations", "Test")
                        .WithMany("TestQuestions")
                        .HasForeignKey("TestId")
                        .HasConstraintName("FKTest_Quest411060")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.TestResults", b =>
                {
                    b.HasOne("Entities.Models.TestAnswers", "Answer")
                        .WithMany("TestResults")
                        .HasForeignKey("AnswerId")
                        .HasConstraintName("FKTest_Resul169939")
                        .IsRequired();

                    b.HasOne("Entities.Models.TestQuestions", "Question")
                        .WithMany("TestResults")
                        .HasForeignKey("QuestionId")
                        .HasConstraintName("FKTest_Resul345735")
                        .IsRequired();

                    b.HasOne("Entities.Models.TestDeclarations", "Test")
                        .WithMany("TestResults")
                        .HasForeignKey("TestId")
                        .HasConstraintName("FKTest_Resul403288")
                        .IsRequired();

                    b.HasOne("Entities.Models.SysUser", "User")
                        .WithMany("TestResults")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FKTest_Resul11694")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.UserLearningPath", b =>
                {
                    b.HasOne("Entities.Models.LearningPaths", "LearningPath")
                        .WithMany("UserLearningPath")
                        .HasForeignKey("LearningPathId")
                        .HasConstraintName("FKUser_Learn182352")
                        .IsRequired();

                    b.HasOne("Entities.Models.SysUser", "User")
                        .WithMany("UserLearningPath")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FKUser_Learn707353")
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Models.VcGuidance", b =>
                {
                    b.HasOne("Entities.Models.Colleges", "College")
                        .WithMany("VcGuidance")
                        .HasForeignKey("CollegeId")
                        .HasConstraintName("FKVC_Guidanc491547")
                        .IsRequired();

                    b.HasOne("Entities.Models.Majors", "Major")
                        .WithMany("VcGuidance")
                        .HasForeignKey("MajorId")
                        .HasConstraintName("FKVC_Guidanc283920")
                        .IsRequired();

                    b.HasOne("Entities.Models.SysUser", "User")
                        .WithMany("VcGuidance")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FKVC_Guidanc169535")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

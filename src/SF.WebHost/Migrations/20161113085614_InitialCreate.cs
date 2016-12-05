﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SF.WebHost.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Core_UserToken",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "Core_AutoHistory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AfterJson = table.Column<string>(maxLength: 2048, nullable: true),
                    BeforeJson = table.Column<string>(maxLength: 2048, nullable: true),
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Kind = table.Column<int>(nullable: false),
                    SourceId = table.Column<string>(maxLength: 50, nullable: false),
                    TypeName = table.Column<string>(maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_AutoHistory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_CountryEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_CountryEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_DataItem",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    DeleteMark = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    EnabledMark = table.Column<int>(nullable: true),
                    IsNav = table.Column<int>(nullable: true),
                    IsTree = table.Column<int>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    ItemName = table.Column<string>(nullable: true),
                    ParentId = table.Column<long>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_DataItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_EntityType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RoutingAction = table.Column<string>(nullable: true),
                    RoutingController = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_EntityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_MediaEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Caption = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    FileName = table.Column<string>(nullable: true),
                    FileSize = table.Column<int>(nullable: false),
                    MediaType = table.Column<int>(nullable: false),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_MediaEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_NotificationEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AttemptCount = table.Column<int>(nullable: false),
                    Body = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsSuccessSend = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(maxLength: 10, nullable: true),
                    LastFailAttemptDate = table.Column<DateTime>(nullable: true),
                    LastFailAttemptMessage = table.Column<string>(nullable: true),
                    MaxAttemptCount = table.Column<int>(nullable: false),
                    ObjectId = table.Column<string>(maxLength: 128, nullable: true),
                    ObjectTypeId = table.Column<string>(maxLength: 128, nullable: true),
                    Recipient = table.Column<string>(maxLength: 128, nullable: true),
                    Sender = table.Column<string>(maxLength: 128, nullable: true),
                    SendingGateway = table.Column<string>(maxLength: 128, nullable: true),
                    SentDate = table.Column<DateTime>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    StartSendingDate = table.Column<DateTime>(nullable: true),
                    Subject = table.Column<string>(maxLength: 512, nullable: true),
                    Type = table.Column<string>(maxLength: 128, nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_NotificationEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_NotificationTemplateEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Body = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    IsDefault = table.Column<bool>(nullable: false),
                    Language = table.Column<string>(maxLength: 10, nullable: true),
                    NotificationTypeId = table.Column<string>(maxLength: 128, nullable: true),
                    ObjectId = table.Column<string>(maxLength: 128, nullable: true),
                    ObjectTypeId = table.Column<string>(maxLength: 128, nullable: true),
                    Recipient = table.Column<string>(nullable: true),
                    Sender = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    TemplateEngine = table.Column<string>(maxLength: 64, nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_NotificationTemplateEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_Permission",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: false),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Permission", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_Role",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Core_SettingValue",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Description = table.Column<string>(maxLength: 1024, nullable: true),
                    IsEnum = table.Column<bool>(nullable: false),
                    IsLocaleDependant = table.Column<bool>(nullable: false),
                    IsMultiValue = table.Column<bool>(nullable: false),
                    IsSystem = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    ObjectType = table.Column<string>(maxLength: 128, nullable: true),
                    SettingValueType = table.Column<string>(maxLength: 64, nullable: false),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_SettingValue", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLog_ActivityType",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLog_ActivityType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Localization_CultureEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localization_CultureEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_StateOrProvinceEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_StateOrProvinceEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entitys_StateOrProvinceEntity_Entitys_CountryEntity_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Entitys_CountryEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_DataItemDetail",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    DeleteMark = table.Column<int>(nullable: true),
                    Description = table.Column<string>(maxLength: 1000, nullable: true),
                    EnabledMark = table.Column<int>(nullable: true),
                    IsDefault = table.Column<int>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    ItemId = table.Column<long>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    ItemValue = table.Column<string>(nullable: true),
                    ParentId = table.Column<long>(nullable: true),
                    QuickQuery = table.Column<string>(nullable: true),
                    SimpleSpelling = table.Column<string>(nullable: true),
                    SortCode = table.Column<int>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_DataItemDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_DataItemDetail_Core_DataItem_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Core_DataItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_UrlSlugEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    EntityId = table.Column<long>(nullable: false),
                    EntityTypeId = table.Column<long>(nullable: false),
                    Slug = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_UrlSlugEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entitys_UrlSlugEntity_Entitys_EntityType_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalTable: "Entitys_EntityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_RoleClaim_Core_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Core_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_RolePermission",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    PermissionId = table.Column<long>(nullable: false),
                    RoleId = table.Column<long>(nullable: false),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_RolePermission", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_RolePermission_Core_Permission_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Core_Permission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Core_RolePermission_Core_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Core_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_SettingValueEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BooleanValue = table.Column<bool>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    DateTimeValue = table.Column<DateTime>(nullable: true),
                    DecimalValue = table.Column<decimal>(nullable: false),
                    IntegerValue = table.Column<int>(nullable: false),
                    Locale = table.Column<string>(maxLength: 64, nullable: true),
                    LongTextValue = table.Column<string>(nullable: true),
                    SettingId = table.Column<long>(nullable: false),
                    ShortTextValue = table.Column<string>(maxLength: 512, nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false),
                    ValueType = table.Column<string>(maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_SettingValueEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entitys_SettingValueEntity_Core_SettingValue_SettingId",
                        column: x => x.SettingId,
                        principalTable: "Core_SettingValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ActivityLog_ActivityEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ActivityTypeId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    EntityId = table.Column<long>(nullable: false),
                    EntityTypeId = table.Column<long>(nullable: false),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLog_ActivityEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityLog_ActivityEntity_ActivityLog_ActivityType_ActivityTypeId",
                        column: x => x.ActivityTypeId,
                        principalTable: "ActivityLog_ActivityType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Localization_ResourceEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    CultureId = table.Column<long>(nullable: true),
                    Key = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Localization_ResourceEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Localization_ResourceEntity_Localization_CultureEntity_CultureId",
                        column: x => x.CultureId,
                        principalTable: "Localization_CultureEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_DistrictEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    StateOrProvinceId = table.Column<long>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_DistrictEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entitys_DistrictEntity_Entitys_StateOrProvinceEntity_StateOrProvinceId",
                        column: x => x.StateOrProvinceId,
                        principalTable: "Entitys_StateOrProvinceEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_PermissionScope",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    Label = table.Column<string>(maxLength: 1024, nullable: true),
                    RolePermissionId = table.Column<long>(nullable: false),
                    Scope = table.Column<string>(maxLength: 1024, nullable: false),
                    Sortindex = table.Column<int>(nullable: false),
                    Type = table.Column<string>(maxLength: 255, nullable: true),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_PermissionScope", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_PermissionScope_Core_RolePermission_RolePermissionId",
                        column: x => x.RolePermissionId,
                        principalTable: "Core_RolePermission",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_AddressEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddressLine2 = table.Column<string>(nullable: true),
                    ContactName = table.Column<string>(nullable: true),
                    CountryId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    DistrictId = table.Column<long>(nullable: false),
                    Phone = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    StateOrProvinceId = table.Column<long>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_AddressEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entitys_AddressEntity_Entitys_CountryEntity_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Entitys_CountryEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entitys_AddressEntity_Entitys_DistrictEntity_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Entitys_DistrictEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entitys_AddressEntity_Entitys_StateOrProvinceEntity_StateOrProvinceId",
                        column: x => x.StateOrProvinceId,
                        principalTable: "Entitys_StateOrProvinceEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entitys_UserAddressEntity",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<long>(nullable: false),
                    AddressType = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    LastUsedOn = table.Column<DateTimeOffset>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys_UserAddressEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entitys_UserAddressEntity_Entitys_AddressEntity_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Entitys_AddressEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_User",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    AccountState = table.Column<string>(maxLength: 128, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    CurrentShippingAddressId = table.Column<long>(nullable: true),
                    DeletedBy = table.Column<string>(maxLength: 128, nullable: true),
                    DeletedOn = table.Column<DateTimeOffset>(nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    FullName = table.Column<string>(nullable: true),
                    IsAdministrator = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    SecurityStamp = table.Column<string>(nullable: true),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false),
                    UserGuid = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    UserType = table.Column<string>(maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_User_Entitys_UserAddressEntity_CurrentShippingAddressId",
                        column: x => x.CurrentShippingAddressId,
                        principalTable: "Entitys_UserAddressEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_UserClaim_Core_User_UserId",
                        column: x => x.UserId,
                        principalTable: "Core_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_UserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_Core_UserLogin_Core_User_UserId",
                        column: x => x.UserId,
                        principalTable: "Core_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_ApiAccount",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<long>(nullable: false),
                    ApiAccountType = table.Column<int>(nullable: false),
                    AppId = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTimeOffset>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: true),
                    SecretKey = table.Column<string>(nullable: true),
                    Sortindex = table.Column<int>(nullable: false),
                    UpdatedBy = table.Column<string>(maxLength: 128, nullable: false),
                    UpdatedOn = table.Column<DateTimeOffset>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_ApiAccount", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Core_ApiAccount_Core_User_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Core_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Core_UserRole",
                columns: table => new
                {
                    UserId = table.Column<long>(nullable: false),
                    RoleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_Core_UserRole_Core_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Core_Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Core_UserRole_Core_User_UserId",
                        column: x => x.UserId,
                        principalTable: "Core_User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Core_RoleClaim_RoleId",
                table: "Core_RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_UserClaim_UserId",
                table: "Core_UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_UserLogin_UserId",
                table: "Core_UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_AddressEntity_CountryId",
                table: "Entitys_AddressEntity",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_AddressEntity_DistrictId",
                table: "Entitys_AddressEntity",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_AddressEntity_StateOrProvinceId",
                table: "Entitys_AddressEntity",
                column: "StateOrProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_ApiAccount_AccountId",
                table: "Core_ApiAccount",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_DataItemDetail_ItemId",
                table: "Core_DataItemDetail",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_DistrictEntity_StateOrProvinceId",
                table: "Entitys_DistrictEntity",
                column: "StateOrProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_PermissionScope_RolePermissionId",
                table: "Core_PermissionScope",
                column: "RolePermissionId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Core_Role",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_Core_RolePermission_PermissionId",
                table: "Core_RolePermission",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_RolePermission_RoleId",
                table: "Core_RolePermission",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_SettingValueEntity_SettingId",
                table: "Entitys_SettingValueEntity",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_StateOrProvinceEntity_CountryId",
                table: "Entitys_StateOrProvinceEntity",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_UrlSlugEntity_EntityTypeId",
                table: "Entitys_UrlSlugEntity",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_UserAddressEntity_AddressId",
                table: "Entitys_UserAddressEntity",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Entitys_UserAddressEntity_UserId",
                table: "Entitys_UserAddressEntity",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_User_CurrentShippingAddressId",
                table: "Core_User",
                column: "CurrentShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Core_User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Core_User",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Core_UserRole_RoleId",
                table: "Core_UserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_UserRole_UserId",
                table: "Core_UserRole",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityLog_ActivityEntity_ActivityTypeId",
                table: "ActivityLog_ActivityEntity",
                column: "ActivityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Localization_ResourceEntity_CultureId",
                table: "Localization_ResourceEntity",
                column: "CultureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Entitys_UserAddressEntity_Core_User_UserId",
                table: "Entitys_UserAddressEntity",
                column: "UserId",
                principalTable: "Core_User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Entitys_UserAddressEntity_Core_User_UserId",
                table: "Entitys_UserAddressEntity");

            migrationBuilder.DropTable(
                name: "Core_RoleClaim");

            migrationBuilder.DropTable(
                name: "Core_UserClaim");

            migrationBuilder.DropTable(
                name: "Core_UserLogin");

            migrationBuilder.DropTable(
                name: "Core_UserToken");

            migrationBuilder.DropTable(
                name: "Core_AutoHistory");

            migrationBuilder.DropTable(
                name: "Core_ApiAccount");

            migrationBuilder.DropTable(
                name: "Core_DataItemDetail");

            migrationBuilder.DropTable(
                name: "Entitys_MediaEntity");

            migrationBuilder.DropTable(
                name: "Entitys_NotificationEntity");

            migrationBuilder.DropTable(
                name: "Entitys_NotificationTemplateEntity");

            migrationBuilder.DropTable(
                name: "Core_PermissionScope");

            migrationBuilder.DropTable(
                name: "Entitys_SettingValueEntity");

            migrationBuilder.DropTable(
                name: "Entitys_UrlSlugEntity");

            migrationBuilder.DropTable(
                name: "Core_UserRole");

            migrationBuilder.DropTable(
                name: "ActivityLog_ActivityEntity");

            migrationBuilder.DropTable(
                name: "Localization_ResourceEntity");

            migrationBuilder.DropTable(
                name: "Core_DataItem");

            migrationBuilder.DropTable(
                name: "Core_RolePermission");

            migrationBuilder.DropTable(
                name: "Core_SettingValue");

            migrationBuilder.DropTable(
                name: "Entitys_EntityType");

            migrationBuilder.DropTable(
                name: "ActivityLog_ActivityType");

            migrationBuilder.DropTable(
                name: "Localization_CultureEntity");

            migrationBuilder.DropTable(
                name: "Core_Permission");

            migrationBuilder.DropTable(
                name: "Core_Role");

            migrationBuilder.DropTable(
                name: "Core_User");

            migrationBuilder.DropTable(
                name: "Entitys_UserAddressEntity");

            migrationBuilder.DropTable(
                name: "Entitys_AddressEntity");

            migrationBuilder.DropTable(
                name: "Entitys_DistrictEntity");

            migrationBuilder.DropTable(
                name: "Entitys_StateOrProvinceEntity");

            migrationBuilder.DropTable(
                name: "Entitys_CountryEntity");
        }
    }
}

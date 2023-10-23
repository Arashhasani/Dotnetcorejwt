using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JwtPrpject.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1329cfb4-71da-46da-a491-fdbe0e43ec06"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("257a9198-7947-46b7-9877-ca07721c6d32"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("9b6471a3-3f6e-4624-a2c8-6881ba2b35de"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a1d17246-3d64-4a73-b6ff-3bfda32585e9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0636d1c4-9a73-4a2f-bc1a-dde86a6f62a5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0aac8633-a14b-4247-b911-1d99b451f116"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1627c8d1-a8ec-4a43-9112-ccc2e35fd11e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e1cc269-f8b0-498e-aaa6-d127a31e45ce"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2701b8f2-d189-4988-a97d-dc40863e355d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a54c7e0-04b5-4666-96f9-9685a859a94a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("47f18954-4adc-4330-a987-0972465777cc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59d30bea-0786-4379-bcc5-24b88001575a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b59c85e-59c3-42b5-a7e1-55fc6c162dd0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("67295f4e-0180-469f-90eb-159b9d1bc151"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("70be3b58-24fd-43c2-a64a-fc26ea610b20"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a1e98495-1c71-4e19-b579-86e892659482"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a9dda043-4773-4df2-8945-eaae42893308"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ad130363-cd87-4c82-a30f-0bdf7a152acb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c05d7086-b20c-461e-9d07-43f3fbf20f36"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c337ea3e-31d3-4996-bbf6-0a64c21f9be5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e6afbfc2-bfb5-447a-9040-8a54e719e488"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ee4ebd7f-c3b5-4ee2-b93b-d994a0a6f188"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f548a89a-8c28-4b1c-9783-20b31d1592e0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("fac9ff11-de8d-4c26-b7f6-4b9587eeb3c2"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1707b145-2654-46dd-866d-8bef534be08b"), "AREH" },
                    { new Guid("35556ee0-6031-4db2-841b-834275b6876c"), "BEAK" },
                    { new Guid("b016ce4d-88a5-4537-85bf-df8768d7d65c"), "98YM" },
                    { new Guid("c0a16c13-acf5-4720-9ea0-bede63446981"), "8ELM" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("0194d703-52e1-4ff4-9fce-07001b4139df"), "4L288LST@gmail.com", "DTTZ", "FEQVQX6EQN" },
                    { new Guid("04f330b6-9bb5-48bd-9236-2a80a490091d"), "SAAHZ7VG@gmail.com", "6JRE", "ULAFX6PLLN" },
                    { new Guid("0df91b27-c883-4512-81ca-ad3fcb9ad299"), "YUODQM5E@gmail.com", "12Q6", "D7SOON09HF" },
                    { new Guid("2cc87196-216c-48c1-a2b4-6b4479f56fba"), "4LO12NPO@gmail.com", "YUHL", "F18163AAG7" },
                    { new Guid("2f3d9ca0-64b9-4b76-b6b5-b103f30502a6"), "21YNGF2Z@gmail.com", "BOXK", "R2O9TZNZUG" },
                    { new Guid("4d33a550-e32a-4429-8e2a-e295bb130a9c"), "REXFQLLX@gmail.com", "D1RS", "0ETVUBYKX8" },
                    { new Guid("674f7b19-caab-41ed-bca7-b0761c53e129"), "QT5AA4EN@gmail.com", "0RQF", "YDZ6RJSTJU" },
                    { new Guid("906e9253-974e-434d-9583-9a24f1054862"), "HYYIN6A7@gmail.com", "D796", "6R6EHPYP4V" },
                    { new Guid("aff57280-094e-4d72-a406-16b061873447"), "NULGVNBY@gmail.com", "EY41", "69DEM3Z2HP" },
                    { new Guid("b12957a0-d6ae-4ef6-8f28-51136664b2d7"), "D1O2A4J9@gmail.com", "I9QM", "YBMNY6N27G" },
                    { new Guid("b3c66201-3845-4696-b62b-2ae8bad5c43d"), "C2KKYHCD@gmail.com", "EVY2", "LYIY79SH2R" },
                    { new Guid("b974dce7-9d01-4c9e-bb00-5834085eda7a"), "N3PSOMW9@gmail.com", "4UNX", "W3WZN04XPK" },
                    { new Guid("c6e31221-f75b-4904-bed1-0b8e01170e8e"), "VZ200UJW@gmail.com", "0SE8", "T3UYH556TX" },
                    { new Guid("c7400323-7b9e-4919-9147-d024f550ba12"), "X247JUNP@gmail.com", "PNI2", "0EGBYM7EQ9" },
                    { new Guid("c7880f16-031d-438b-a483-7d3ab2796c86"), "9OL0F9IV@gmail.com", "3NBM", "MYIQMVL5JY" },
                    { new Guid("c7951a10-73fc-41b9-abd0-7da82e905631"), "H0Z7YRUT@gmail.com", "MGBJ", "KOX9TH6PGT" },
                    { new Guid("d6bfaeff-5ba9-463e-a11a-2240ccc7d866"), "731E483Z@gmail.com", "RNGH", "QB1SDV27VO" },
                    { new Guid("dd217136-ad6f-4dad-aa63-37f87967fdaa"), "9BQHI40V@gmail.com", "6YGM", "60HDG01K5Z" },
                    { new Guid("e1bdda8b-12b2-4580-a2e1-64c5aa63b5b2"), "90VGKQ0Q@gmail.com", "UO9E", "ZXH9VJECX0" },
                    { new Guid("ffd61845-3503-4ffd-a5bd-2ecd1e7f84a1"), "ZHDYX84A@gmail.com", "XR0T", "QV7R1IDFR0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1707b145-2654-46dd-866d-8bef534be08b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("35556ee0-6031-4db2-841b-834275b6876c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b016ce4d-88a5-4537-85bf-df8768d7d65c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0a16c13-acf5-4720-9ea0-bede63446981"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0194d703-52e1-4ff4-9fce-07001b4139df"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("04f330b6-9bb5-48bd-9236-2a80a490091d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0df91b27-c883-4512-81ca-ad3fcb9ad299"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2cc87196-216c-48c1-a2b4-6b4479f56fba"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2f3d9ca0-64b9-4b76-b6b5-b103f30502a6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4d33a550-e32a-4429-8e2a-e295bb130a9c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("674f7b19-caab-41ed-bca7-b0761c53e129"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("906e9253-974e-434d-9583-9a24f1054862"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("aff57280-094e-4d72-a406-16b061873447"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b12957a0-d6ae-4ef6-8f28-51136664b2d7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b3c66201-3845-4696-b62b-2ae8bad5c43d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b974dce7-9d01-4c9e-bb00-5834085eda7a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c6e31221-f75b-4904-bed1-0b8e01170e8e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7400323-7b9e-4919-9147-d024f550ba12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7880f16-031d-438b-a483-7d3ab2796c86"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c7951a10-73fc-41b9-abd0-7da82e905631"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("d6bfaeff-5ba9-463e-a11a-2240ccc7d866"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("dd217136-ad6f-4dad-aa63-37f87967fdaa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e1bdda8b-12b2-4580-a2e1-64c5aa63b5b2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ffd61845-3503-4ffd-a5bd-2ecd1e7f84a1"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1329cfb4-71da-46da-a491-fdbe0e43ec06"), "G36I" },
                    { new Guid("257a9198-7947-46b7-9877-ca07721c6d32"), "HEVX" },
                    { new Guid("9b6471a3-3f6e-4624-a2c8-6881ba2b35de"), "EDR2" },
                    { new Guid("a1d17246-3d64-4a73-b6ff-3bfda32585e9"), "9FN8" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("0636d1c4-9a73-4a2f-bc1a-dde86a6f62a5"), "24POMMGU@gmail.com", "XP6W", "JUIPJH420O" },
                    { new Guid("0aac8633-a14b-4247-b911-1d99b451f116"), "Q5A3I105@gmail.com", "UGQO", "1YW2AXXSZR" },
                    { new Guid("1627c8d1-a8ec-4a43-9112-ccc2e35fd11e"), "B12JJ5JM@gmail.com", "JTNJ", "7YT3WFREVH" },
                    { new Guid("1e1cc269-f8b0-498e-aaa6-d127a31e45ce"), "KWTC690W@gmail.com", "IQ9E", "UDRJJIEP1B" },
                    { new Guid("2701b8f2-d189-4988-a97d-dc40863e355d"), "E541SVB8@gmail.com", "QLR4", "A69CRI17J7" },
                    { new Guid("3a54c7e0-04b5-4666-96f9-9685a859a94a"), "T3Z2ZVHG@gmail.com", "07ZU", "QFGXDVJZGG" },
                    { new Guid("47f18954-4adc-4330-a987-0972465777cc"), "768EI05J@gmail.com", "R9H9", "4OIFLEDBDE" },
                    { new Guid("59d30bea-0786-4379-bcc5-24b88001575a"), "9ORY2WDU@gmail.com", "TWUB", "1ZPFBIE4AT" },
                    { new Guid("5b59c85e-59c3-42b5-a7e1-55fc6c162dd0"), "AETB1K5I@gmail.com", "SIYX", "610MJPODMY" },
                    { new Guid("67295f4e-0180-469f-90eb-159b9d1bc151"), "I4SDCNMP@gmail.com", "7PXL", "AXWZ2ATOOM" },
                    { new Guid("70be3b58-24fd-43c2-a64a-fc26ea610b20"), "EQWOCCWN@gmail.com", "901F", "UG329TNCSA" },
                    { new Guid("a1e98495-1c71-4e19-b579-86e892659482"), "YGXCWKTO@gmail.com", "RGED", "Y76JM1A1FH" },
                    { new Guid("a9dda043-4773-4df2-8945-eaae42893308"), "NBSCBAFG@gmail.com", "QRTN", "MDPKL3ZJZC" },
                    { new Guid("ad130363-cd87-4c82-a30f-0bdf7a152acb"), "C8ZUSOR4@gmail.com", "B5HW", "PXWWF6K93B" },
                    { new Guid("c05d7086-b20c-461e-9d07-43f3fbf20f36"), "ZG3LVZGQ@gmail.com", "0THY", "WW9YB7P4P0" },
                    { new Guid("c337ea3e-31d3-4996-bbf6-0a64c21f9be5"), "81TVQP7C@gmail.com", "8NIX", "AYP8VDYKC6" },
                    { new Guid("e6afbfc2-bfb5-447a-9040-8a54e719e488"), "1FIFJR05@gmail.com", "9HS8", "ODWTL2KD8Z" },
                    { new Guid("ee4ebd7f-c3b5-4ee2-b93b-d994a0a6f188"), "5GBDTCES@gmail.com", "UU83", "542BDO0OSM" },
                    { new Guid("f548a89a-8c28-4b1c-9783-20b31d1592e0"), "XJKXF025@gmail.com", "OAAK", "XK29PG8F2P" },
                    { new Guid("fac9ff11-de8d-4c26-b7f6-4b9587eeb3c2"), "IU9OT6DS@gmail.com", "5CFK", "WXK9B7KF7M" }
                });
        }
    }
}

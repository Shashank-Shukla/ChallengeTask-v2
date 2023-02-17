using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeTask_v2.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "collateral_Agreements",
                columns: table => new
                {
                    CollateralAgreementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collateral_Agreements", x => x.CollateralAgreementID);
                });

            migrationBuilder.CreateTable(
                name: "contract_s",
                columns: table => new
                {
                    ContractFrequenciesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Collateral_Agreements_IDCollateralAgreementID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contract_s", x => x.ContractFrequenciesID);
                    table.ForeignKey(
                        name: "FK_contract_s_collateral_Agreements_Collateral_Agreements_IDCollateralAgreementID",
                        column: x => x.Collateral_Agreements_IDCollateralAgreementID,
                        principalTable: "collateral_Agreements",
                        principalColumn: "CollateralAgreementID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "frequencies",
                columns: table => new
                {
                    InterestFrequencyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contract_Frequencies_IDContractFrequenciesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_frequencies", x => x.InterestFrequencyID);
                    table.ForeignKey(
                        name: "FK_frequencies_contract_s_Contract_Frequencies_IDContractFrequenciesID",
                        column: x => x.Contract_Frequencies_IDContractFrequenciesID,
                        principalTable: "contract_s",
                        principalColumn: "ContractFrequenciesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contract_s_Collateral_Agreements_IDCollateralAgreementID",
                table: "contract_s",
                column: "Collateral_Agreements_IDCollateralAgreementID");

            migrationBuilder.CreateIndex(
                name: "IX_frequencies_Contract_Frequencies_IDContractFrequenciesID",
                table: "frequencies",
                column: "Contract_Frequencies_IDContractFrequenciesID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "frequencies");

            migrationBuilder.DropTable(
                name: "contract_s");

            migrationBuilder.DropTable(
                name: "collateral_Agreements");
        }
    }
}

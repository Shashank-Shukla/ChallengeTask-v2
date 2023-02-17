using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChallengeTask_v2.Migrations
{
    /// <inheritdoc />
    public partial class M2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contract_s_collateral_Agreements_Collateral_Agreements_IDCollateralAgreementID",
                table: "contract_s");

            migrationBuilder.DropForeignKey(
                name: "FK_frequencies_contract_s_Contract_Frequencies_IDContractFrequenciesID",
                table: "frequencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_collateral_Agreements",
                table: "collateral_Agreements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_frequencies",
                table: "frequencies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_contract_s",
                table: "contract_s");

            migrationBuilder.RenameTable(
                name: "collateral_Agreements",
                newName: "Collateral_Agreements");

            migrationBuilder.RenameTable(
                name: "frequencies",
                newName: "Interest_Frequency");

            migrationBuilder.RenameTable(
                name: "contract_s",
                newName: "Contract_Frequencies");

            migrationBuilder.RenameIndex(
                name: "IX_frequencies_Contract_Frequencies_IDContractFrequenciesID",
                table: "Interest_Frequency",
                newName: "IX_Interest_Frequency_Contract_Frequencies_IDContractFrequenciesID");

            migrationBuilder.RenameIndex(
                name: "IX_contract_s_Collateral_Agreements_IDCollateralAgreementID",
                table: "Contract_Frequencies",
                newName: "IX_Contract_Frequencies_Collateral_Agreements_IDCollateralAgreementID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Collateral_Agreements",
                table: "Collateral_Agreements",
                column: "CollateralAgreementID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interest_Frequency",
                table: "Interest_Frequency",
                column: "InterestFrequencyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contract_Frequencies",
                table: "Contract_Frequencies",
                column: "ContractFrequenciesID");

            migrationBuilder.AddForeignKey(
                name: "FK_Contract_Frequencies_Collateral_Agreements_Collateral_Agreements_IDCollateralAgreementID",
                table: "Contract_Frequencies",
                column: "Collateral_Agreements_IDCollateralAgreementID",
                principalTable: "Collateral_Agreements",
                principalColumn: "CollateralAgreementID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Interest_Frequency_Contract_Frequencies_Contract_Frequencies_IDContractFrequenciesID",
                table: "Interest_Frequency",
                column: "Contract_Frequencies_IDContractFrequenciesID",
                principalTable: "Contract_Frequencies",
                principalColumn: "ContractFrequenciesID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contract_Frequencies_Collateral_Agreements_Collateral_Agreements_IDCollateralAgreementID",
                table: "Contract_Frequencies");

            migrationBuilder.DropForeignKey(
                name: "FK_Interest_Frequency_Contract_Frequencies_Contract_Frequencies_IDContractFrequenciesID",
                table: "Interest_Frequency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Collateral_Agreements",
                table: "Collateral_Agreements");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interest_Frequency",
                table: "Interest_Frequency");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contract_Frequencies",
                table: "Contract_Frequencies");

            migrationBuilder.RenameTable(
                name: "Collateral_Agreements",
                newName: "collateral_Agreements");

            migrationBuilder.RenameTable(
                name: "Interest_Frequency",
                newName: "frequencies");

            migrationBuilder.RenameTable(
                name: "Contract_Frequencies",
                newName: "contract_s");

            migrationBuilder.RenameIndex(
                name: "IX_Interest_Frequency_Contract_Frequencies_IDContractFrequenciesID",
                table: "frequencies",
                newName: "IX_frequencies_Contract_Frequencies_IDContractFrequenciesID");

            migrationBuilder.RenameIndex(
                name: "IX_Contract_Frequencies_Collateral_Agreements_IDCollateralAgreementID",
                table: "contract_s",
                newName: "IX_contract_s_Collateral_Agreements_IDCollateralAgreementID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_collateral_Agreements",
                table: "collateral_Agreements",
                column: "CollateralAgreementID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_frequencies",
                table: "frequencies",
                column: "InterestFrequencyID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_contract_s",
                table: "contract_s",
                column: "ContractFrequenciesID");

            migrationBuilder.AddForeignKey(
                name: "FK_contract_s_collateral_Agreements_Collateral_Agreements_IDCollateralAgreementID",
                table: "contract_s",
                column: "Collateral_Agreements_IDCollateralAgreementID",
                principalTable: "collateral_Agreements",
                principalColumn: "CollateralAgreementID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_frequencies_contract_s_Contract_Frequencies_IDContractFrequenciesID",
                table: "frequencies",
                column: "Contract_Frequencies_IDContractFrequenciesID",
                principalTable: "contract_s",
                principalColumn: "ContractFrequenciesID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

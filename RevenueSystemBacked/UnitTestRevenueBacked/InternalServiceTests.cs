using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
using Moq;
using DataAccess.Services;
using DataAccess.SqlAccess;
using DataAccess.Models;

namespace UnitTestRevenueBacked
{
    public class InternalServiceTests
    {
        private readonly Mock<ISqlAccessInternal> _mockSqlAccessInternal;

        public InternalServiceTests()
        {
            _mockSqlAccessInternal = new Mock<ISqlAccessInternal>();
        }

        [Fact]
        public async Task GetRecordsAsync_ShouldReturnRecords()
        {
            // Arrange
            var expectedRecords = new List<ExpenseIncomeRecord>
        {
            new ExpenseIncomeRecord { RecordId = 1, Account = "Account1" },
            new ExpenseIncomeRecord { RecordId = 2, Account = "Account2" }
        };

            _mockSqlAccessInternal
                .Setup(x => x.LoadDataAsync<ExpenseIncomeRecord, dynamic>("dbo.spGetAllExpenseIncomeRecordsWithDetails", It.IsAny<object>()))
                .ReturnsAsync(expectedRecords);

            var service = new InternalService(_mockSqlAccessInternal.Object);

            // Act
            var result = await service.GetRecordsAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(2, result.Count());
            Assert.Equal(expectedRecords[0].RecordId, result.First().RecordId);
        }

        [Fact]
        public async Task SaveRecordAsync_ShouldCallUpdateAsync()
        {
            // Arrange
            var expenseIncomeRecordAdd = new ExpenseIncomeRecordAdd
            {
                Account = "NewAccount",
                DetailId = 1,
                IsIncomeOrExpense = "Expense",
                Value = 100.5m,
                Date = DateTime.Now
            };

            _mockSqlAccessInternal
                .Setup(x => x.UpdateAsync("dbo.spAddExpenseIncomeRecord", It.IsAny<object>()))
                .Returns(Task.CompletedTask);

            var service = new InternalService(_mockSqlAccessInternal.Object);

            // Act
            await service.SaveRecordAsync(expenseIncomeRecordAdd);

            // Assert
            _mockSqlAccessInternal.Verify(x => x.UpdateAsync("dbo.spAddExpenseIncomeRecord", It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public async Task DeleteRecordAsync_ShouldCallUpdateAsync()
        {
            // Arrange
            var recordId = 1;

            _mockSqlAccessInternal
                .Setup(x => x.UpdateAsync("dbo.spDeleteExpenseIncomeRecord", It.IsAny<object>()))
                .Returns(Task.CompletedTask);

            var service = new InternalService(_mockSqlAccessInternal.Object);

            // Act
            await service.DeleteRecordAsync(recordId);

            // Assert
            _mockSqlAccessInternal.Verify(x => x.UpdateAsync("dbo.spDeleteExpenseIncomeRecord", It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public async Task UpdateRecordAsync_ShouldCallUpdateAsync()
        {
            // Arrange
            var recordId = 1;
            var expenseIncomeRecordAdd = new ExpenseIncomeRecordAdd
            {
                Account = "UpdatedAccount",
                DetailId = 1,
                IsIncomeOrExpense = "Income",
                Value = 200.0m,
                Date = DateTime.Now
            };

            _mockSqlAccessInternal
                .Setup(x => x.UpdateAsync("dbo.spUpdateExpenseIncomeRecord", It.IsAny<object>()))
                .Returns(Task.CompletedTask);

            var service = new InternalService(_mockSqlAccessInternal.Object);

            // Act
            await service.UpdateRecordAsync(recordId, expenseIncomeRecordAdd);

            // Assert
            _mockSqlAccessInternal.Verify(x => x.UpdateAsync("dbo.spUpdateExpenseIncomeRecord", It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public async Task GetAllDetailTypesAsync_ShouldReturnDetailTypes()
        {
            // Arrange
            var expectedDetails = new List<DetailTypes>
        {
            new DetailTypes { DetailId = 1, Detail = "Detail1", Type = "Type1" },
            new DetailTypes { DetailId = 2, Detail = "Detail2", Type = "Type2" }
        };

            _mockSqlAccessInternal
                .Setup(x => x.LoadDataAsync<DetailTypes, dynamic>("dbo.spGetAllDetails", It.IsAny<object>()))
                .ReturnsAsync(expectedDetails);

            var service = new InternalService(_mockSqlAccessInternal.Object);

            // Act
            var result = await service.GetAllDetailTypesAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Equal(expectedDetails.Count, result.Count());
            Assert.Equal(expectedDetails.First().DetailId, result.First().DetailId);
        }

        [Fact]
        public async Task SaveDetailTypesAsync_ShouldCallUpdateAsync()
        {
            // Arrange
            var detailType = new DetailTypes
            {
                DetailId = 1,
                Detail = "New Detail",
                Type = "New Type"
            };

            _mockSqlAccessInternal
                .Setup(x => x.UpdateAsync("dbo.spAddDetailIncomeExpense", It.IsAny<object>()))
                .Returns(Task.CompletedTask);

            var service = new InternalService(_mockSqlAccessInternal.Object);

            // Act
            await service.SaveDetailTypesAsync(detailType);

            // Assert
            _mockSqlAccessInternal.Verify(x => x.UpdateAsync("dbo.spAddDetailIncomeExpense", It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public async Task DeleteDetailTypesAsync_ShouldCallUpdateAsync()
        {
            // Arrange
            var detailType = new DetailTypes
            {
                DetailId = 1,
                Detail = "Detail to Delete",
                Type = "Type to Delete"
            };

            _mockSqlAccessInternal
                .Setup(x => x.UpdateAsync("dbo.spDeleteDetailIncomeExpense", It.IsAny<object>()))
                .Returns(Task.CompletedTask);

            var service = new InternalService(_mockSqlAccessInternal.Object);

            // Act
            await service.DeleteDetailTypesAsync(detailType);

            // Assert
            _mockSqlAccessInternal.Verify(x => x.UpdateAsync("dbo.spDeleteDetailIncomeExpense", It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public async Task UpdateDetailTypesAsync_ShouldCallUpdateAsync()
        {
            // Arrange
            var detailType = new DetailTypes
            {
                DetailId = 1,
                Detail = "Updated Detail",
                Type = "Updated Type"
            };

            _mockSqlAccessInternal
                .Setup(x => x.UpdateAsync("dbo.spUpdateDetailIncomeExpense", It.IsAny<object>()))
                .Returns(Task.CompletedTask);

            var service = new InternalService(_mockSqlAccessInternal.Object);

            // Act
            await service.UpdateDetailTypesAsync(detailType);

            // Assert
            _mockSqlAccessInternal.Verify(x => x.UpdateAsync("dbo.spUpdateDetailIncomeExpense", It.IsAny<object>()), Times.Once);
        }
    }
}

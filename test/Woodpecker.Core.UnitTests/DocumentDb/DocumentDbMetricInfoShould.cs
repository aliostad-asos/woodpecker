﻿using Woodpecker.Core.DocumentDb.Infrastructure;
using Xunit;

namespace Woodpecker.Core.UnitTests.DocumentDb
{
    public class DocumentDbMetricInfoShould
    {
        private string subscriptionId;
        private string resourceGroupName;
        private string documentDbAccount;
        private string databaseId;
        private string collectionId;

        public DocumentDbMetricInfoShould()
        {
            this.subscriptionId = "mytestsubscription";
            this.resourceGroupName = "testresourcegroup";
            this.documentDbAccount = "testdocdbaccount";
            this.databaseId = "myDatabase";
            this.collectionId = "myCollection";
        }

        [Fact]
        public void Return_The_Resource_Uri()
        {
            // Arrange
            this.subscriptionId = "mytestsubscription";
            this.resourceGroupName = "testresourcegroup";
            this.documentDbAccount = "testdocdbaccount";
            this.databaseId = "myDatabase";
            this.collectionId = "myCollection";

            var expected = "subscriptions/mytestsubscription/resourceGroups/testresourcegroup/providers/Microsoft.DocumentDB/databaseAccounts/testdocdbaccount/databases/myDatabase/collections/myCollection";


            // Act
            var sut = this.Sut(subscriptionId, resourceGroupName, documentDbAccount, databaseId, collectionId);
            var actual = sut.ResourceId;

            // Assert
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Gather_A_Pre_Determined_Set_Of_Metrics()
        {
            // Arrange
            var expected = new string[]
            {
                "Available Storage",
                "Average Requests per Second",
                "Data Size",
                "Document Count",
                "Index Size",
                "Max RUs Per Second",
                "Observed Read Latency",
                "Observed Write Latency",
                "Throttled Requests",
                "Total Request Units",
                "Total Requests"
            };


            // Act
            var sut = this.Sut(subscriptionId, resourceGroupName, documentDbAccount, databaseId, collectionId);
            var actual = sut.MetricsToGather;

            // Assert
            Assert.Equal(actual, expected);

        }

        private IMetricsInfo Sut(string subscriptionId,
            string resourceGroupName,
            string documentDbAccount,
            string databaseId,
            string collectionId)
        {
            return null; // new DocumentDbMetricsInfo(subscriptionId,resourceGroupName,documentDbAccount,databaseId,collectionId);
        }
    }
}
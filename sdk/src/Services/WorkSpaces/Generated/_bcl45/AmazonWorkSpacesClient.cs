/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.WorkSpaces.Model;
using Amazon.WorkSpaces.Model.Internal.MarshallTransformations;
using Amazon.WorkSpaces.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.WorkSpaces
{
    /// <summary>
    /// Implementation for accessing WorkSpaces
    ///
    /// Amazon WorkSpaces Service 
    /// <para>
    /// Amazon WorkSpaces enables you to provision virtual, cloud-based Microsoft Windows
    /// and Amazon Linux desktops for your users.
    /// </para>
    /// </summary>
    public partial class AmazonWorkSpacesClient : AmazonServiceClient, IAmazonWorkSpaces
    {
        private static IServiceMetadata serviceMetadata = new AmazonWorkSpacesMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonWorkSpacesClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkSpacesConfig()) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonWorkSpacesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(AmazonWorkSpacesConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials)
            : this(credentials, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonWorkSpacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Credentials and an
        /// AmazonWorkSpacesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(AWSCredentials credentials, AmazonWorkSpacesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonWorkSpacesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonWorkSpacesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonWorkSpacesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonWorkSpacesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonWorkSpacesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonWorkSpacesClient Configuration Object</param>
        public AmazonWorkSpacesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonWorkSpacesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AssociateIpGroups


        /// <summary>
        /// Associates the specified IP access control group with the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpGroups service method.</param>
        /// 
        /// <returns>The response from the AssociateIpGroups service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateIpGroups">REST API Reference for AssociateIpGroups Operation</seealso>
        public virtual AssociateIpGroupsResponse AssociateIpGroups(AssociateIpGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpGroupsResponseUnmarshaller.Instance;

            return Invoke<AssociateIpGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIpGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIpGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AssociateIpGroups">REST API Reference for AssociateIpGroups Operation</seealso>
        public virtual Task<AssociateIpGroupsResponse> AssociateIpGroupsAsync(AssociateIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIpGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateIpGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeIpRules


        /// <summary>
        /// Adds one or more rules to the specified IP access control group.
        /// 
        ///  
        /// <para>
        /// This action gives users permission to access their WorkSpaces from the CIDR address
        /// ranges specified in the rules.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeIpRules service method.</param>
        /// 
        /// <returns>The response from the AuthorizeIpRules service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AuthorizeIpRules">REST API Reference for AuthorizeIpRules Operation</seealso>
        public virtual AuthorizeIpRulesResponse AuthorizeIpRules(AuthorizeIpRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeIpRulesResponseUnmarshaller.Instance;

            return Invoke<AuthorizeIpRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeIpRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeIpRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/AuthorizeIpRules">REST API Reference for AuthorizeIpRules Operation</seealso>
        public virtual Task<AuthorizeIpRulesResponse> AuthorizeIpRulesAsync(AuthorizeIpRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeIpRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<AuthorizeIpRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateIpGroup


        /// <summary>
        /// Creates an IP access control group.
        /// 
        ///  
        /// <para>
        /// An IP access control group provides you with the ability to control the IP addresses
        /// from which users are allowed to access their WorkSpaces. To specify the CIDR address
        /// ranges, add rules to your IP access control group and then associate the group with
        /// your directory. You can add rules when you create the group or at any time using <a>AuthorizeIpRules</a>.
        /// </para>
        ///  
        /// <para>
        /// There is a default IP access control group associated with your directory. If you
        /// don't associate an IP access control group with your directory, the default group
        /// is used. The default group includes a default rule that allows users to access their
        /// WorkSpaces from anywhere. You cannot modify the default IP access control group for
        /// your directory.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIpGroup service method.</param>
        /// 
        /// <returns>The response from the CreateIpGroup service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceCreationFailedException">
        /// The resource could not be created.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateIpGroup">REST API Reference for CreateIpGroup Operation</seealso>
        public virtual CreateIpGroupResponse CreateIpGroup(CreateIpGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpGroupResponseUnmarshaller.Instance;

            return Invoke<CreateIpGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIpGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIpGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateIpGroup">REST API Reference for CreateIpGroup Operation</seealso>
        public virtual Task<CreateIpGroupResponse> CreateIpGroupAsync(CreateIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIpGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateIpGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Creates the specified tags for the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateWorkspaces


        /// <summary>
        /// Creates one or more WorkSpaces.
        /// 
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces are created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaces service method.</param>
        /// 
        /// <returns>The response from the CreateWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaces">REST API Reference for CreateWorkspaces Operation</seealso>
        public virtual CreateWorkspacesResponse CreateWorkspaces(CreateWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;

            return Invoke<CreateWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/CreateWorkspaces">REST API Reference for CreateWorkspaces Operation</seealso>
        public virtual Task<CreateWorkspacesResponse> CreateWorkspacesAsync(CreateWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteIpGroup


        /// <summary>
        /// Deletes the specified IP access control group.
        /// 
        ///  
        /// <para>
        /// You cannot delete an IP access control group that is associated with a directory.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteIpGroup service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAssociatedException">
        /// The resource is associated with a directory.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteIpGroup">REST API Reference for DeleteIpGroup Operation</seealso>
        public virtual DeleteIpGroupResponse DeleteIpGroup(DeleteIpGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteIpGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIpGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIpGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteIpGroup">REST API Reference for DeleteIpGroup Operation</seealso>
        public virtual Task<DeleteIpGroupResponse> DeleteIpGroupAsync(DeleteIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIpGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteIpGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified tags from the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteWorkspaceImage


        /// <summary>
        /// Deletes the specified image from your account. To delete an image, you must first
        /// delete any bundles that are associated with the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceImage service method.</param>
        /// 
        /// <returns>The response from the DeleteWorkspaceImage service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAssociatedException">
        /// The resource is associated with a directory.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceImage">REST API Reference for DeleteWorkspaceImage Operation</seealso>
        public virtual DeleteWorkspaceImageResponse DeleteWorkspaceImage(DeleteWorkspaceImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<DeleteWorkspaceImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteWorkspaceImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DeleteWorkspaceImage">REST API Reference for DeleteWorkspaceImage Operation</seealso>
        public virtual Task<DeleteWorkspaceImageResponse> DeleteWorkspaceImageAsync(DeleteWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWorkspaceImageResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteWorkspaceImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccount


        /// <summary>
        /// Retrieves a list that describes the configuration of bring your own license (BYOL)
        /// for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount service method.</param>
        /// 
        /// <returns>The response from the DescribeAccount service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public virtual DescribeAccountResponse DescribeAccount(DescribeAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccount">REST API Reference for DescribeAccount Operation</seealso>
        public virtual Task<DescribeAccountResponse> DescribeAccountAsync(DescribeAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountModifications


        /// <summary>
        /// Retrieves a list that describes modifications to the configuration of bring your own
        /// license (BYOL) for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountModifications service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccountModifications">REST API Reference for DescribeAccountModifications Operation</seealso>
        public virtual DescribeAccountModificationsResponse DescribeAccountModifications(DescribeAccountModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountModificationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeAccountModifications">REST API Reference for DescribeAccountModifications Operation</seealso>
        public virtual Task<DescribeAccountModificationsResponse> DescribeAccountModificationsAsync(DescribeAccountModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountModificationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeAccountModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientProperties


        /// <summary>
        /// Retrieves a list that describes one or more specified Amazon WorkSpaces clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientProperties service method.</param>
        /// 
        /// <returns>The response from the DescribeClientProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientProperties">REST API Reference for DescribeClientProperties Operation</seealso>
        public virtual DescribeClientPropertiesResponse DescribeClientProperties(DescribeClientPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientPropertiesResponseUnmarshaller.Instance;

            return Invoke<DescribeClientPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientProperties operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeClientProperties">REST API Reference for DescribeClientProperties Operation</seealso>
        public virtual Task<DescribeClientPropertiesResponse> DescribeClientPropertiesAsync(DescribeClientPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientPropertiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeClientPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIpGroups


        /// <summary>
        /// Describes one or more of your IP access control groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeIpGroups service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeIpGroups">REST API Reference for DescribeIpGroups Operation</seealso>
        public virtual DescribeIpGroupsResponse DescribeIpGroups(DescribeIpGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIpGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeIpGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIpGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIpGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeIpGroups">REST API Reference for DescribeIpGroups Operation</seealso>
        public virtual Task<DescribeIpGroupsResponse> DescribeIpGroupsAsync(DescribeIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIpGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeIpGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the specified tags for the specified WorkSpaces resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceBundles


        /// <summary>
        /// Retrieves a list that describes the available WorkSpace bundles.
        /// 
        ///  
        /// <para>
        /// You can filter the results using either bundle ID or owner, but not both.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles()
        {
            var request = new DescribeWorkspaceBundlesRequest();
            return DescribeWorkspaceBundles(request);
        }


        /// <summary>
        /// Retrieves a list that describes the available WorkSpace bundles.
        /// 
        ///  
        /// <para>
        /// You can filter the results using either bundle ID or owner, but not both.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceBundles service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual DescribeWorkspaceBundlesResponse DescribeWorkspaceBundles(DescribeWorkspaceBundlesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceBundlesResponse>(request, options);
        }


        /// <summary>
        /// Retrieves a list that describes the available WorkSpace bundles.
        /// 
        ///  
        /// <para>
        /// You can filter the results using either bundle ID or owner, but not both.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceBundles service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual Task<DescribeWorkspaceBundlesResponse> DescribeWorkspaceBundlesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspaceBundlesRequest();
            return DescribeWorkspaceBundlesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceBundles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceBundles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceBundles">REST API Reference for DescribeWorkspaceBundles Operation</seealso>
        public virtual Task<DescribeWorkspaceBundlesResponse> DescribeWorkspaceBundlesAsync(DescribeWorkspaceBundlesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceBundlesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceBundlesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWorkspaceBundlesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceDirectories


        /// <summary>
        /// Describes the available AWS Directory Service directories that are registered with
        /// Amazon WorkSpaces.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories()
        {
            var request = new DescribeWorkspaceDirectoriesRequest();
            return DescribeWorkspaceDirectories(request);
        }


        /// <summary>
        /// Describes the available AWS Directory Service directories that are registered with
        /// Amazon WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceDirectories service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual DescribeWorkspaceDirectoriesResponse DescribeWorkspaceDirectories(DescribeWorkspaceDirectoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceDirectoriesResponse>(request, options);
        }


        /// <summary>
        /// Describes the available AWS Directory Service directories that are registered with
        /// Amazon WorkSpaces.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaceDirectories service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual Task<DescribeWorkspaceDirectoriesResponse> DescribeWorkspaceDirectoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspaceDirectoriesRequest();
            return DescribeWorkspaceDirectoriesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceDirectories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceDirectories operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceDirectories">REST API Reference for DescribeWorkspaceDirectories Operation</seealso>
        public virtual Task<DescribeWorkspaceDirectoriesResponse> DescribeWorkspaceDirectoriesAsync(DescribeWorkspaceDirectoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceDirectoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceDirectoriesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWorkspaceDirectoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaceImages


        /// <summary>
        /// Retrieves a list that describes one or more specified images, if the image identifiers
        /// are provided. Otherwise, all images in the account are described.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceImages service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaceImages service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImages">REST API Reference for DescribeWorkspaceImages Operation</seealso>
        public virtual DescribeWorkspaceImagesResponse DescribeWorkspaceImages(DescribeWorkspaceImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspaceImagesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaceImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaceImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaceImages">REST API Reference for DescribeWorkspaceImages Operation</seealso>
        public virtual Task<DescribeWorkspaceImagesResponse> DescribeWorkspaceImagesAsync(DescribeWorkspaceImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspaceImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspaceImagesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWorkspaceImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspaces


        /// <summary>
        /// Describes the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You can filter the results by using the bundle identifier, directory identifier, or
        /// owner, but you can specify only one filter at a time.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual DescribeWorkspacesResponse DescribeWorkspaces()
        {
            var request = new DescribeWorkspacesRequest();
            return DescribeWorkspaces(request);
        }


        /// <summary>
        /// Describes the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You can filter the results by using the bundle identifier, directory identifier, or
        /// owner, but you can specify only one filter at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaces service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual DescribeWorkspacesResponse DescribeWorkspaces(DescribeWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesResponse>(request, options);
        }


        /// <summary>
        /// Describes the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You can filter the results by using the bundle identifier, directory identifier, or
        /// owner, but you can specify only one filter at a time.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual Task<DescribeWorkspacesResponse> DescribeWorkspacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DescribeWorkspacesRequest();
            return DescribeWorkspacesAsync(request, cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspaces">REST API Reference for DescribeWorkspaces Operation</seealso>
        public virtual Task<DescribeWorkspacesResponse> DescribeWorkspacesAsync(DescribeWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeWorkspacesConnectionStatus


        /// <summary>
        /// Describes the connection status of the specified WorkSpaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesConnectionStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeWorkspacesConnectionStatus service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesConnectionStatus">REST API Reference for DescribeWorkspacesConnectionStatus Operation</seealso>
        public virtual DescribeWorkspacesConnectionStatusResponse DescribeWorkspacesConnectionStatus(DescribeWorkspacesConnectionStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesConnectionStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeWorkspacesConnectionStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeWorkspacesConnectionStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeWorkspacesConnectionStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DescribeWorkspacesConnectionStatus">REST API Reference for DescribeWorkspacesConnectionStatus Operation</seealso>
        public virtual Task<DescribeWorkspacesConnectionStatusResponse> DescribeWorkspacesConnectionStatusAsync(DescribeWorkspacesConnectionStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeWorkspacesConnectionStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeWorkspacesConnectionStatusResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeWorkspacesConnectionStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateIpGroups


        /// <summary>
        /// Disassociates the specified IP access control group from the specified directory.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpGroups service method.</param>
        /// 
        /// <returns>The response from the DisassociateIpGroups service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateIpGroups">REST API Reference for DisassociateIpGroups Operation</seealso>
        public virtual DisassociateIpGroupsResponse DisassociateIpGroups(DisassociateIpGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpGroupsResponseUnmarshaller.Instance;

            return Invoke<DisassociateIpGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIpGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIpGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/DisassociateIpGroups">REST API Reference for DisassociateIpGroups Operation</seealso>
        public virtual Task<DisassociateIpGroupsResponse> DisassociateIpGroupsAsync(DisassociateIpGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIpGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIpGroupsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateIpGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportWorkspaceImage


        /// <summary>
        /// Imports the specified Windows 7 or Windows 10 bring your own license (BYOL) image
        /// into Amazon WorkSpaces. The image must be an already licensed EC2 image that is in
        /// your AWS account, and you must own the image.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportWorkspaceImage service method.</param>
        /// 
        /// <returns>The response from the ImportWorkspaceImage service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationNotSupportedException">
        /// This operation is not supported.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportWorkspaceImage">REST API Reference for ImportWorkspaceImage Operation</seealso>
        public virtual ImportWorkspaceImageResponse ImportWorkspaceImage(ImportWorkspaceImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportWorkspaceImageResponseUnmarshaller.Instance;

            return Invoke<ImportWorkspaceImageResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportWorkspaceImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportWorkspaceImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ImportWorkspaceImage">REST API Reference for ImportWorkspaceImage Operation</seealso>
        public virtual Task<ImportWorkspaceImageResponse> ImportWorkspaceImageAsync(ImportWorkspaceImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportWorkspaceImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportWorkspaceImageResponseUnmarshaller.Instance;
            
            return InvokeAsync<ImportWorkspaceImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAvailableManagementCidrRanges


        /// <summary>
        /// Retrieves a list of IP address ranges, specified as IPv4 CIDR blocks, that you can
        /// use for the network management interface when you enable bring your own license (BYOL).
        /// 
        /// 
        ///  
        /// <para>
        /// The management network interface is connected to a secure Amazon WorkSpaces management
        /// network. It is used for interactive streaming of the WorkSpace desktop to Amazon WorkSpaces
        /// clients, and to allow Amazon WorkSpaces to manage the WorkSpace.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagementCidrRanges service method.</param>
        /// 
        /// <returns>The response from the ListAvailableManagementCidrRanges service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAvailableManagementCidrRanges">REST API Reference for ListAvailableManagementCidrRanges Operation</seealso>
        public virtual ListAvailableManagementCidrRangesResponse ListAvailableManagementCidrRanges(ListAvailableManagementCidrRangesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableManagementCidrRangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagementCidrRangesResponseUnmarshaller.Instance;

            return Invoke<ListAvailableManagementCidrRangesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAvailableManagementCidrRanges operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAvailableManagementCidrRanges operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ListAvailableManagementCidrRanges">REST API Reference for ListAvailableManagementCidrRanges Operation</seealso>
        public virtual Task<ListAvailableManagementCidrRangesResponse> ListAvailableManagementCidrRangesAsync(ListAvailableManagementCidrRangesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAvailableManagementCidrRangesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAvailableManagementCidrRangesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAvailableManagementCidrRangesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyAccount


        /// <summary>
        /// Modifies the configuration of bring your own license (BYOL) for the specified account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyAccount service method.</param>
        /// 
        /// <returns>The response from the ModifyAccount service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyAccount">REST API Reference for ModifyAccount Operation</seealso>
        public virtual ModifyAccountResponse ModifyAccount(ModifyAccountRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAccountResponseUnmarshaller.Instance;

            return Invoke<ModifyAccountResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyAccount operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyAccount operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyAccount">REST API Reference for ModifyAccount Operation</seealso>
        public virtual Task<ModifyAccountResponse> ModifyAccountAsync(ModifyAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyAccountResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyAccountResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClientProperties


        /// <summary>
        /// Modifies the properties of the specified Amazon WorkSpaces clients.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClientProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyClientProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyClientProperties">REST API Reference for ModifyClientProperties Operation</seealso>
        public virtual ModifyClientPropertiesResponse ModifyClientProperties(ModifyClientPropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientPropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyClientPropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClientProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClientProperties operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyClientProperties">REST API Reference for ModifyClientProperties Operation</seealso>
        public virtual Task<ModifyClientPropertiesResponse> ModifyClientPropertiesAsync(ModifyClientPropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClientPropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientPropertiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyClientPropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyWorkspaceProperties


        /// <summary>
        /// Modifies the specified WorkSpace properties.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceProperties service method.</param>
        /// 
        /// <returns>The response from the ModifyWorkspaceProperties service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.OperationInProgressException">
        /// The properties of this WorkSpace are currently being modified. Try again in a moment.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceUnavailableException">
        /// The specified resource is not available.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.UnsupportedWorkspaceConfigurationException">
        /// The configuration of this WorkSpace is not supported for this operation. For more
        /// information, see the <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/">Amazon
        /// WorkSpaces Administration Guide</a>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceProperties">REST API Reference for ModifyWorkspaceProperties Operation</seealso>
        public virtual ModifyWorkspacePropertiesResponse ModifyWorkspaceProperties(ModifyWorkspacePropertiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspacePropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspacePropertiesResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspacePropertiesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyWorkspaceProperties operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceProperties operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceProperties">REST API Reference for ModifyWorkspaceProperties Operation</seealso>
        public virtual Task<ModifyWorkspacePropertiesResponse> ModifyWorkspacePropertiesAsync(ModifyWorkspacePropertiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspacePropertiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspacePropertiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyWorkspacePropertiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyWorkspaceState


        /// <summary>
        /// Sets the state of the specified WorkSpace.
        /// 
        ///  
        /// <para>
        /// To maintain a WorkSpace without being interrupted, set the WorkSpace state to <code>ADMIN_MAINTENANCE</code>.
        /// WorkSpaces in this state do not respond to requests to reboot, stop, start, or rebuild.
        /// An AutoStop WorkSpace in this state is not stopped. Users can log into a WorkSpace
        /// in the <code>ADMIN_MAINTENANCE</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceState service method.</param>
        /// 
        /// <returns>The response from the ModifyWorkspaceState service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceState">REST API Reference for ModifyWorkspaceState Operation</seealso>
        public virtual ModifyWorkspaceStateResponse ModifyWorkspaceState(ModifyWorkspaceStateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceStateResponseUnmarshaller.Instance;

            return Invoke<ModifyWorkspaceStateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyWorkspaceState operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyWorkspaceState operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/ModifyWorkspaceState">REST API Reference for ModifyWorkspaceState Operation</seealso>
        public virtual Task<ModifyWorkspaceStateResponse> ModifyWorkspaceStateAsync(ModifyWorkspaceStateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyWorkspaceStateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyWorkspaceStateResponseUnmarshaller.Instance;
            
            return InvokeAsync<ModifyWorkspaceStateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootWorkspaces


        /// <summary>
        /// Reboots the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot reboot a WorkSpace unless its state is <code>AVAILABLE</code> or <code>UNHEALTHY</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have rebooted.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootWorkspaces service method.</param>
        /// 
        /// <returns>The response from the RebootWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebootWorkspaces">REST API Reference for RebootWorkspaces Operation</seealso>
        public virtual RebootWorkspacesResponse RebootWorkspaces(RebootWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;

            return Invoke<RebootWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebootWorkspaces">REST API Reference for RebootWorkspaces Operation</seealso>
        public virtual Task<RebootWorkspacesResponse> RebootWorkspacesAsync(RebootWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebootWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebuildWorkspaces


        /// <summary>
        /// Rebuilds the specified WorkSpace.
        /// 
        ///  
        /// <para>
        /// You cannot rebuild a WorkSpace unless its state is <code>AVAILABLE</code>, <code>ERROR</code>,
        /// or <code>UNHEALTHY</code>.
        /// </para>
        ///  
        /// <para>
        /// Rebuilding a WorkSpace is a potentially destructive action that can result in the
        /// loss of data. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/reset-workspace.html">Rebuild
        /// a WorkSpace</a>.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have been completely
        /// rebuilt.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebuildWorkspaces service method.</param>
        /// 
        /// <returns>The response from the RebuildWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebuildWorkspaces">REST API Reference for RebuildWorkspaces Operation</seealso>
        public virtual RebuildWorkspacesResponse RebuildWorkspaces(RebuildWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebuildWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;

            return Invoke<RebuildWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebuildWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebuildWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RebuildWorkspaces">REST API Reference for RebuildWorkspaces Operation</seealso>
        public virtual Task<RebuildWorkspacesResponse> RebuildWorkspacesAsync(RebuildWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebuildWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebuildWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<RebuildWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeIpRules


        /// <summary>
        /// Removes one or more rules from the specified IP access control group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeIpRules service method.</param>
        /// 
        /// <returns>The response from the RevokeIpRules service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RevokeIpRules">REST API Reference for RevokeIpRules Operation</seealso>
        public virtual RevokeIpRulesResponse RevokeIpRules(RevokeIpRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeIpRulesResponseUnmarshaller.Instance;

            return Invoke<RevokeIpRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeIpRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeIpRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/RevokeIpRules">REST API Reference for RevokeIpRules Operation</seealso>
        public virtual Task<RevokeIpRulesResponse> RevokeIpRulesAsync(RevokeIpRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeIpRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeIpRulesResponseUnmarshaller.Instance;
            
            return InvokeAsync<RevokeIpRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartWorkspaces


        /// <summary>
        /// Starts the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot start a WorkSpace unless it has a running mode of <code>AutoStop</code>
        /// and a state of <code>STOPPED</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspaces service method.</param>
        /// 
        /// <returns>The response from the StartWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspaces">REST API Reference for StartWorkspaces Operation</seealso>
        public virtual StartWorkspacesResponse StartWorkspaces(StartWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkspacesResponseUnmarshaller.Instance;

            return Invoke<StartWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StartWorkspaces">REST API Reference for StartWorkspaces Operation</seealso>
        public virtual Task<StartWorkspacesResponse> StartWorkspacesAsync(StartWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopWorkspaces


        /// <summary>
        /// Stops the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// You cannot stop a WorkSpace unless it has a running mode of <code>AutoStop</code>
        /// and a state of <code>AVAILABLE</code>, <code>IMPAIRED</code>, <code>UNHEALTHY</code>,
        /// or <code>ERROR</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspaces service method.</param>
        /// 
        /// <returns>The response from the StopWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspaces">REST API Reference for StopWorkspaces Operation</seealso>
        public virtual StopWorkspacesResponse StopWorkspaces(StopWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkspacesResponseUnmarshaller.Instance;

            return Invoke<StopWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/StopWorkspaces">REST API Reference for StopWorkspaces Operation</seealso>
        public virtual Task<StopWorkspacesResponse> StopWorkspacesAsync(StopWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<StopWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateWorkspaces


        /// <summary>
        /// Terminates the specified WorkSpaces.
        /// 
        ///  
        /// <para>
        /// Terminating a WorkSpace is a permanent action and cannot be undone. The user's data
        /// is destroyed. If you need to archive any user data, contact Amazon Web Services before
        /// terminating the WorkSpace.
        /// </para>
        ///  
        /// <para>
        /// You can terminate a WorkSpace that is in any state except <code>SUSPENDED</code>.
        /// </para>
        ///  
        /// <para>
        /// This operation is asynchronous and returns before the WorkSpaces have been completely
        /// terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspaces service method.</param>
        /// 
        /// <returns>The response from the TerminateWorkspaces service method, as returned by WorkSpaces.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspaces">REST API Reference for TerminateWorkspaces Operation</seealso>
        public virtual TerminateWorkspacesResponse TerminateWorkspaces(TerminateWorkspacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;

            return Invoke<TerminateWorkspacesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateWorkspaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateWorkspaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/TerminateWorkspaces">REST API Reference for TerminateWorkspaces Operation</seealso>
        public virtual Task<TerminateWorkspacesResponse> TerminateWorkspacesAsync(TerminateWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<TerminateWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRulesOfIpGroup


        /// <summary>
        /// Replaces the current rules of the specified IP access control group with the specified
        /// rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRulesOfIpGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateRulesOfIpGroup service method, as returned by WorkSpaces.</returns>
        /// <exception cref="Amazon.WorkSpaces.Model.AccessDeniedException">
        /// The user is not authorized to access a resource.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidParameterValuesException">
        /// One or more parameter values are not valid.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.InvalidResourceStateException">
        /// The state of the resource is not valid for this operation.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceLimitExceededException">
        /// Your resource limits have been exceeded.
        /// </exception>
        /// <exception cref="Amazon.WorkSpaces.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateRulesOfIpGroup">REST API Reference for UpdateRulesOfIpGroup Operation</seealso>
        public virtual UpdateRulesOfIpGroupResponse UpdateRulesOfIpGroup(UpdateRulesOfIpGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRulesOfIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRulesOfIpGroupResponseUnmarshaller.Instance;

            return Invoke<UpdateRulesOfIpGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRulesOfIpGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRulesOfIpGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/workspaces-2015-04-08/UpdateRulesOfIpGroup">REST API Reference for UpdateRulesOfIpGroup Operation</seealso>
        public virtual Task<UpdateRulesOfIpGroupResponse> UpdateRulesOfIpGroupAsync(UpdateRulesOfIpGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRulesOfIpGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRulesOfIpGroupResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateRulesOfIpGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}